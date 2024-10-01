//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputLayoutCodeGenerator
//     version 1.9.0
//     from "Mouse" layout
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

// Suppress warnings from local variables for control references
// that we don't end up using.
#pragma warning disable CS0219

namespace UnityEngine.InputSystem
{
    internal partial class FastMouse : UnityEngine.InputSystem.Mouse
    {
        public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer";
        public FastMouse()
        {
            var builder = this.Setup(30, 10, 2)
                .WithName("Mouse")
                .WithDisplayName("Mouse")
                .WithChildren(0, 14)
                .WithLayout(new InternedString("Mouse"))
                .WithStateBlock(new InputStateBlock { format = new FourCC(1297044819), sizeInBits = 392 });

            var kVector2Layout = new InternedString("Vector2");
            var kDeltaLayout = new InternedString("Delta");
            var kButtonLayout = new InternedString("Button");
            var kAxisLayout = new InternedString("Axis");
            var kDigitalLayout = new InternedString("Digital");
            var kIntegerLayout = new InternedString("Integer");

            // /Mouse/position
            var ctrlMouseposition = Initialize_ctrlMouseposition(kVector2Layout, this);

            // /Mouse/delta
            var ctrlMousedelta = Initialize_ctrlMousedelta(kDeltaLayout, this);

            // /Mouse/scroll
            var ctrlMousescroll = Initialize_ctrlMousescroll(kDeltaLayout, this);

            // /Mouse/press
            var ctrlMousepress = Initialize_ctrlMousepress(kButtonLayout, this);

            // /Mouse/leftButton
            var ctrlMouseleftButton = Initialize_ctrlMouseleftButton(kButtonLayout, this);

            // /Mouse/rightButton
            var ctrlMouserightButton = Initialize_ctrlMouserightButton(kButtonLayout, this);

            // /Mouse/middleButton
            var ctrlMousemiddleButton = Initialize_ctrlMousemiddleButton(kButtonLayout, this);

            // /Mouse/forwardButton
            var ctrlMouseforwardButton = Initialize_ctrlMouseforwardButton(kButtonLayout, this);

            // /Mouse/backButton
            var ctrlMousebackButton = Initialize_ctrlMousebackButton(kButtonLayout, this);

            // /Mouse/pressure
            var ctrlMousepressure = Initialize_ctrlMousepressure(kAxisLayout, this);

            // /Mouse/radius
            var ctrlMouseradius = Initialize_ctrlMouseradius(kVector2Layout, this);

            // /Mouse/pointerId
            var ctrlMousepointerId = Initialize_ctrlMousepointerId(kDigitalLayout, this);

            // /Mouse/displayIndex
            var ctrlMousedisplayIndex = Initialize_ctrlMousedisplayIndex(kIntegerLayout, this);

            // /Mouse/clickCount
            var ctrlMouseclickCount = Initialize_ctrlMouseclickCount(kIntegerLayout, this);

            // /Mouse/position/x
            var ctrlMousepositionx = Initialize_ctrlMousepositionx(kAxisLayout, ctrlMouseposition);

            // /Mouse/position/y
            var ctrlMousepositiony = Initialize_ctrlMousepositiony(kAxisLayout, ctrlMouseposition);

            // /Mouse/delta/up
            var ctrlMousedeltaup = Initialize_ctrlMousedeltaup(kAxisLayout, ctrlMousedelta);

            // /Mouse/delta/down
            var ctrlMousedeltadown = Initialize_ctrlMousedeltadown(kAxisLayout, ctrlMousedelta);

            // /Mouse/delta/left
            var ctrlMousedeltaleft = Initialize_ctrlMousedeltaleft(kAxisLayout, ctrlMousedelta);

            // /Mouse/delta/right
            var ctrlMousedeltaright = Initialize_ctrlMousedeltaright(kAxisLayout, ctrlMousedelta);

            // /Mouse/delta/x
            var ctrlMousedeltax = Initialize_ctrlMousedeltax(kAxisLayout, ctrlMousedelta);

            // /Mouse/delta/y
            var ctrlMousedeltay = Initialize_ctrlMousedeltay(kAxisLayout, ctrlMousedelta);

            // /Mouse/scroll/up
            var ctrlMousescrollup = Initialize_ctrlMousescrollup(kAxisLayout, ctrlMousescroll);

            // /Mouse/scroll/down
            var ctrlMousescrolldown = Initialize_ctrlMousescrolldown(kAxisLayout, ctrlMousescroll);

            // /Mouse/scroll/left
            var ctrlMousescrollleft = Initialize_ctrlMousescrollleft(kAxisLayout, ctrlMousescroll);

            // /Mouse/scroll/right
            var ctrlMousescrollright = Initialize_ctrlMousescrollright(kAxisLayout, ctrlMousescroll);

            // /Mouse/scroll/x
            var ctrlMousescrollx = Initialize_ctrlMousescrollx(kAxisLayout, ctrlMousescroll);

            // /Mouse/scroll/y
            var ctrlMousescrolly = Initialize_ctrlMousescrolly(kAxisLayout, ctrlMousescroll);

            // /Mouse/radius/x
            var ctrlMouseradiusx = Initialize_ctrlMouseradiusx(kAxisLayout, ctrlMouseradius);

            // /Mouse/radius/y
            var ctrlMouseradiusy = Initialize_ctrlMouseradiusy(kAxisLayout, ctrlMouseradius);

            // Usages.
            builder.WithControlUsage(0, new InternedString("Point"), ctrlMouseposition);
            builder.WithControlUsage(1, new InternedString("Secondary2DMotion"), ctrlMousedelta);
            builder.WithControlUsage(2, new InternedString("ScrollHorizontal"), ctrlMousescrollx);
            builder.WithControlUsage(3, new InternedString("ScrollVertical"), ctrlMousescrolly);
            builder.WithControlUsage(4, new InternedString("PrimaryAction"), ctrlMouseleftButton);
            builder.WithControlUsage(5, new InternedString("SecondaryAction"), ctrlMouserightButton);
            builder.WithControlUsage(6, new InternedString("Forward"), ctrlMouseforwardButton);
            builder.WithControlUsage(7, new InternedString("Back"), ctrlMousebackButton);
            builder.WithControlUsage(8, new InternedString("Pressure"), ctrlMousepressure);
            builder.WithControlUsage(9, new InternedString("Radius"), ctrlMouseradius);

            // Aliases.
            builder.WithControlAlias(0,  new InternedString("horizontal"));
            builder.WithControlAlias(1,  new InternedString("vertical"));

            // Control getters/arrays.
            this.scroll = ctrlMousescroll;
            this.leftButton = ctrlMouseleftButton;
            this.middleButton = ctrlMousemiddleButton;
            this.rightButton = ctrlMouserightButton;
            this.backButton = ctrlMousebackButton;
            this.forwardButton = ctrlMouseforwardButton;
            this.clickCount = ctrlMouseclickCount;
            this.position = ctrlMouseposition;
            this.delta = ctrlMousedelta;
            this.radius = ctrlMouseradius;
            this.pressure = ctrlMousepressure;
            this.press = ctrlMousepress;
            this.displayIndex = ctrlMousedisplayIndex;
            ctrlMouseposition.x = ctrlMousepositionx;
            ctrlMouseposition.y = ctrlMousepositiony;
            ctrlMousedelta.up = ctrlMousedeltaup;
            ctrlMousedelta.down = ctrlMousedeltadown;
            ctrlMousedelta.left = ctrlMousedeltaleft;
            ctrlMousedelta.right = ctrlMousedeltaright;
            ctrlMousedelta.x = ctrlMousedeltax;
            ctrlMousedelta.y = ctrlMousedeltay;
            ctrlMousescroll.up = ctrlMousescrollup;
            ctrlMousescroll.down = ctrlMousescrolldown;
            ctrlMousescroll.left = ctrlMousescrollleft;
            ctrlMousescroll.right = ctrlMousescrollright;
            ctrlMousescroll.x = ctrlMousescrollx;
            ctrlMousescroll.y = ctrlMousescrolly;
            ctrlMouseradius.x = ctrlMouseradiusx;
            ctrlMouseradius.y = ctrlMouseradiusy;

            // State offset to control index map.
            builder.WithStateOffsetToControlIndexMap(new uint[]
            {
                32782u, 16809999u, 33587218u, 33587219u, 33587220u, 50364432u, 50364433u, 50364437u, 67141656u, 67141657u
                , 67141658u, 83918870u, 83918871u, 83918875u, 100664323u, 100664324u, 101188613u, 101712902u, 102237191u, 102761480u
                , 109068300u, 117456909u, 134250505u, 167804956u, 184582173u, 201327627u
            });

            builder.WithControlTree(new byte[]
            {
                // Control tree nodes as bytes
                135, 1, 1, 0, 0, 0, 0, 196, 0, 3, 0, 0, 0, 0, 135, 1, 23, 0, 0, 0, 0, 128, 0, 5, 0, 0, 0, 0, 196, 0
                , 11, 0, 0, 0, 0, 64, 0, 7, 0, 0, 0, 1, 128, 0, 9, 0, 3, 0, 1, 32, 0, 255, 255, 1, 0, 1, 64, 0, 255, 255
                , 2, 0, 1, 96, 0, 255, 255, 7, 0, 3, 128, 0, 255, 255, 4, 0, 3, 193, 0, 13, 0, 0, 0, 0, 196, 0, 19, 0, 0, 0
                , 0, 161, 0, 15, 0, 10, 0, 4, 193, 0, 17, 0, 14, 0, 4, 145, 0, 255, 255, 18, 0, 3, 161, 0, 255, 255, 21, 0, 3, 192
                , 0, 255, 255, 0, 0, 0, 193, 0, 255, 255, 24, 0, 2, 195, 0, 21, 0, 0, 0, 0, 196, 0, 255, 255, 28, 0, 1, 194, 0, 255
                , 255, 26, 0, 1, 195, 0, 255, 255, 27, 0, 1, 32, 1, 25, 0, 0, 0, 0, 135, 1, 41, 0, 0, 0, 0, 240, 0, 27, 0, 0
                , 0, 0, 32, 1, 39, 0, 0, 0, 0, 224, 0, 29, 0, 0, 0, 0, 240, 0, 255, 255, 41, 0, 1, 210, 0, 31, 0, 39, 0, 1
                , 224, 0, 255, 255, 40, 0, 1, 203, 0, 33, 0, 0, 0, 0, 210, 0, 255, 255, 0, 0, 0, 200, 0, 35, 0, 0, 0, 0, 203, 0
                , 255, 255, 0, 0, 0, 198, 0, 37, 0, 0, 0, 0, 200, 0, 255, 255, 0, 0, 0, 197, 0, 255, 255, 29, 0, 1, 198, 0, 255, 255
                , 0, 0, 0, 8, 1, 255, 255, 30, 0, 1, 32, 1, 255, 255, 31, 0, 1, 128, 1, 43, 0, 0, 0, 0, 135, 1, 47, 0, 0, 0
                , 0, 80, 1, 255, 255, 32, 0, 2, 128, 1, 45, 0, 34, 0, 2, 104, 1, 255, 255, 36, 0, 1, 128, 1, 255, 255, 37, 0, 1, 132
                , 1, 49, 0, 0, 0, 0, 135, 1, 255, 255, 0, 0, 0, 130, 1, 51, 0, 0, 0, 0, 132, 1, 255, 255, 0, 0, 0, 129, 1, 255
                , 255, 38, 0, 1, 130, 1, 255, 255, 0, 0, 0
            }, new ushort[]
                {
                    // Control tree node indicies

                    0, 14, 15, 1, 16, 17, 21, 18, 19, 20, 2, 22, 23, 27, 2, 22, 23, 27, 24, 25, 26, 24, 25, 26, 3, 4, 5, 6, 7, 8
                    , 9, 9, 10, 28, 10, 28, 29, 29, 11, 12, 12, 13
                });

            builder.Finish();
        }

        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent)
        {
            var ctrlMouseposition = new UnityEngine.InputSystem.Controls.Vector2Control();
            ctrlMouseposition.Setup()
                .At(this, 0)
                .WithParent(parent)
                .WithChildren(14, 2)
                .WithName("position")
                .WithDisplayName("Position")
                .WithLayout(kVector2Layout)
                .WithUsages(0, 1)
                .DontReset(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1447379762),
                    byteOffset = 0,
                    bitOffset = 0,
                    sizeInBits = 64
                })
                #if UNITY_EDITOR
                .WithProcessor<InputProcessor<UnityEngine.Vector2>, UnityEngine.Vector2>(new UnityEngine.InputSystem.Processors.EditorWindowSpaceProcessor())
                #endif
                .Finish();
            return ctrlMouseposition;
        }

        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent)
        {
            var ctrlMousedelta = new UnityEngine.InputSystem.Controls.DeltaControl();
            ctrlMousedelta.Setup()
                .At(this, 1)
                .WithParent(parent)
                .WithChildren(16, 6)
                .WithName("delta")
                .WithDisplayName("Delta")
                .WithLayout(kDeltaLayout)
                .WithUsages(1, 1)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1447379762),
                    byteOffset = 8,
                    bitOffset = 0,
                    sizeInBits = 64
                })
                .Finish();
            return ctrlMousedelta;
        }

        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent)
        {
            var ctrlMousescroll = new UnityEngine.InputSystem.Controls.DeltaControl();
            ctrlMousescroll.Setup()
                .At(this, 2)
                .WithParent(parent)
                .WithChildren(22, 6)
                .WithName("scroll")
                .WithDisplayName("Scroll")
                .WithLayout(kDeltaLayout)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1447379762),
                    byteOffset = 16,
                    bitOffset = 0,
                    sizeInBits = 64
                })
                .Finish();
            return ctrlMousescroll;
        }

        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent)
        {
            var ctrlMousepress = new UnityEngine.InputSystem.Controls.ButtonControl();
            ctrlMousepress.Setup()
                .At(this, 3)
                .WithParent(parent)
                .WithName("press")
                .WithDisplayName("Press")
                .WithLayout(kButtonLayout)
                .IsSynthetic(true)
                .IsButton(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1112101920),
                    byteOffset = 24,
                    bitOffset = 0,
                    sizeInBits = 1
                })
                .WithMinAndMax(0, 1)
                .Finish();
            return ctrlMousepress;
        }

        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent)
        {
            var ctrlMouseleftButton = new UnityEngine.InputSystem.Controls.ButtonControl();
            ctrlMouseleftButton.Setup()
                .At(this, 4)
                .WithParent(parent)
                .WithName("leftButton")
                .WithDisplayName("Left Button")
                .WithShortDisplayName("LMB")
                .WithLayout(kButtonLayout)
                .WithUsages(4, 1)
                .IsButton(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1112101920),
                    byteOffset = 24,
                    bitOffset = 0,
                    sizeInBits = 1
                })
                .WithMinAndMax(0, 1)
                .Finish();
            return ctrlMouseleftButton;
        }

        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent)
        {
            var ctrlMouserightButton = new UnityEngine.InputSystem.Controls.ButtonControl();
            ctrlMouserightButton.Setup()
                .At(this, 5)
                .WithParent(parent)
                .WithName("rightButton")
                .WithDisplayName("Right Button")
                .WithShortDisplayName("RMB")
                .WithLayout(kButtonLayout)
                .WithUsages(5, 1)
                .IsButton(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1112101920),
                    byteOffset = 24,
                    bitOffset = 1,
                    sizeInBits = 1
                })
                .WithMinAndMax(0, 1)
                .Finish();
            return ctrlMouserightButton;
        }

        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent)
        {
            var ctrlMousemiddleButton = new UnityEngine.InputSystem.Controls.ButtonControl();
            ctrlMousemiddleButton.Setup()
                .At(this, 6)
                .WithParent(parent)
                .WithName("middleButton")
                .WithDisplayName("Middle Button")
                .WithShortDisplayName("MMB")
                .WithLayout(kButtonLayout)
                .IsButton(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1112101920),
                    byteOffset = 24,
                    bitOffset = 2,
                    sizeInBits = 1
                })
                .WithMinAndMax(0, 1)
                .Finish();
            return ctrlMousemiddleButton;
        }

        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent)
        {
            var ctrlMouseforwardButton = new UnityEngine.InputSystem.Controls.ButtonControl();
            ctrlMouseforwardButton.Setup()
                .At(this, 7)
                .WithParent(parent)
                .WithName("forwardButton")
                .WithDisplayName("Forward")
                .WithLayout(kButtonLayout)
                .WithUsages(6, 1)
                .IsButton(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1112101920),
                    byteOffset = 24,
                    bitOffset = 3,
                    sizeInBits = 1
                })
                .WithMinAndMax(0, 1)
                .Finish();
            return ctrlMouseforwardButton;
        }

        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent)
        {
            var ctrlMousebackButton = new UnityEngine.InputSystem.Controls.ButtonControl();
            ctrlMousebackButton.Setup()
                .At(this, 8)
                .WithParent(parent)
                .WithName("backButton")
                .WithDisplayName("Back")
                .WithLayout(kButtonLayout)
                .WithUsages(7, 1)
                .IsButton(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1112101920),
                    byteOffset = 24,
                    bitOffset = 4,
                    sizeInBits = 1
                })
                .WithMinAndMax(0, 1)
                .Finish();
            return ctrlMousebackButton;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousepressure = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMousepressure.Setup()
                .At(this, 9)
                .WithParent(parent)
                .WithName("pressure")
                .WithDisplayName("Pressure")
                .WithLayout(kAxisLayout)
                .WithUsages(8, 1)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 32,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .WithDefaultState(1)
                .Finish();
            return ctrlMousepressure;
        }

        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent)
        {
            var ctrlMouseradius = new UnityEngine.InputSystem.Controls.Vector2Control();
            ctrlMouseradius.Setup()
                .At(this, 10)
                .WithParent(parent)
                .WithChildren(28, 2)
                .WithName("radius")
                .WithDisplayName("Radius")
                .WithLayout(kVector2Layout)
                .WithUsages(9, 1)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1447379762),
                    byteOffset = 40,
                    bitOffset = 0,
                    sizeInBits = 64
                })
                .Finish();
            return ctrlMouseradius;
        }

        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent)
        {
            var ctrlMousepointerId = new UnityEngine.InputSystem.Controls.IntegerControl();
            ctrlMousepointerId.Setup()
                .At(this, 11)
                .WithParent(parent)
                .WithName("pointerId")
                .WithDisplayName("pointerId")
                .WithLayout(kDigitalLayout)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1112101920),
                    byteOffset = 48,
                    bitOffset = 0,
                    sizeInBits = 1
                })
                .Finish();
            return ctrlMousepointerId;
        }

        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent)
        {
            var ctrlMousedisplayIndex = new UnityEngine.InputSystem.Controls.IntegerControl();
            ctrlMousedisplayIndex.Setup()
                .At(this, 12)
                .WithParent(parent)
                .WithName("displayIndex")
                .WithDisplayName("Display Index")
                .WithLayout(kIntegerLayout)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1431521364),
                    byteOffset = 26,
                    bitOffset = 0,
                    sizeInBits = 16
                })
                .Finish();
            return ctrlMousedisplayIndex;
        }

        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent)
        {
            var ctrlMouseclickCount = new UnityEngine.InputSystem.Controls.IntegerControl();
            ctrlMouseclickCount.Setup()
                .At(this, 13)
                .WithParent(parent)
                .WithName("clickCount")
                .WithDisplayName("Click Count")
                .WithLayout(kIntegerLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1431521364),
                    byteOffset = 28,
                    bitOffset = 0,
                    sizeInBits = 16
                })
                .Finish();
            return ctrlMouseclickCount;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousepositionx = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMousepositionx.Setup()
                .At(this, 14)
                .WithParent(parent)
                .WithName("x")
                .WithDisplayName("Position X")
                .WithShortDisplayName("Position X")
                .WithLayout(kAxisLayout)
                .DontReset(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 0,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousepositionx;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousepositiony = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMousepositiony.Setup()
                .At(this, 15)
                .WithParent(parent)
                .WithName("y")
                .WithDisplayName("Position Y")
                .WithShortDisplayName("Position Y")
                .WithLayout(kAxisLayout)
                .DontReset(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 4,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousepositiony;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousedeltaup = new UnityEngine.InputSystem.Controls.AxisControl { clamp = UnityEngine.InputSystem.Controls.AxisControl.Clamp.BeforeNormalize, clampMax = 3.402823E+38f };
            ctrlMousedeltaup.Setup()
                .At(this, 16)
                .WithParent(parent)
                .WithName("up")
                .WithDisplayName("Delta Up")
                .WithShortDisplayName("Delta Up")
                .WithLayout(kAxisLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 12,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousedeltaup;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousedeltadown = new UnityEngine.InputSystem.Controls.AxisControl { clamp = UnityEngine.InputSystem.Controls.AxisControl.Clamp.BeforeNormalize, clampMin = -3.402823E+38f, invert = true };
            ctrlMousedeltadown.Setup()
                .At(this, 17)
                .WithParent(parent)
                .WithName("down")
                .WithDisplayName("Delta Down")
                .WithShortDisplayName("Delta Down")
                .WithLayout(kAxisLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 12,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousedeltadown;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousedeltaleft = new UnityEngine.InputSystem.Controls.AxisControl { clamp = UnityEngine.InputSystem.Controls.AxisControl.Clamp.BeforeNormalize, clampMin = -3.402823E+38f, invert = true };
            ctrlMousedeltaleft.Setup()
                .At(this, 18)
                .WithParent(parent)
                .WithName("left")
                .WithDisplayName("Delta Left")
                .WithShortDisplayName("Delta Left")
                .WithLayout(kAxisLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 8,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousedeltaleft;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousedeltaright = new UnityEngine.InputSystem.Controls.AxisControl { clamp = UnityEngine.InputSystem.Controls.AxisControl.Clamp.BeforeNormalize, clampMax = 3.402823E+38f };
            ctrlMousedeltaright.Setup()
                .At(this, 19)
                .WithParent(parent)
                .WithName("right")
                .WithDisplayName("Delta Right")
                .WithShortDisplayName("Delta Right")
                .WithLayout(kAxisLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 8,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousedeltaright;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousedeltax = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMousedeltax.Setup()
                .At(this, 20)
                .WithParent(parent)
                .WithName("x")
                .WithDisplayName("Delta X")
                .WithShortDisplayName("Delta X")
                .WithLayout(kAxisLayout)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 8,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousedeltax;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousedeltay = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMousedeltay.Setup()
                .At(this, 21)
                .WithParent(parent)
                .WithName("y")
                .WithDisplayName("Delta Y")
                .WithShortDisplayName("Delta Y")
                .WithLayout(kAxisLayout)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 12,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousedeltay;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousescrollup = new UnityEngine.InputSystem.Controls.AxisControl { clamp = UnityEngine.InputSystem.Controls.AxisControl.Clamp.BeforeNormalize, clampMax = 3.402823E+38f };
            ctrlMousescrollup.Setup()
                .At(this, 22)
                .WithParent(parent)
                .WithName("up")
                .WithDisplayName("Scroll Up")
                .WithShortDisplayName("Scroll Up")
                .WithLayout(kAxisLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 20,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousescrollup;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousescrolldown = new UnityEngine.InputSystem.Controls.AxisControl { clamp = UnityEngine.InputSystem.Controls.AxisControl.Clamp.BeforeNormalize, clampMin = -3.402823E+38f, invert = true };
            ctrlMousescrolldown.Setup()
                .At(this, 23)
                .WithParent(parent)
                .WithName("down")
                .WithDisplayName("Scroll Down")
                .WithShortDisplayName("Scroll Down")
                .WithLayout(kAxisLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 20,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousescrolldown;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousescrollleft = new UnityEngine.InputSystem.Controls.AxisControl { clamp = UnityEngine.InputSystem.Controls.AxisControl.Clamp.BeforeNormalize, clampMin = -3.402823E+38f, invert = true };
            ctrlMousescrollleft.Setup()
                .At(this, 24)
                .WithParent(parent)
                .WithName("left")
                .WithDisplayName("Scroll Left")
                .WithShortDisplayName("Scroll Left")
                .WithLayout(kAxisLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 16,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousescrollleft;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousescrollright = new UnityEngine.InputSystem.Controls.AxisControl { clamp = UnityEngine.InputSystem.Controls.AxisControl.Clamp.BeforeNormalize, clampMax = 3.402823E+38f };
            ctrlMousescrollright.Setup()
                .At(this, 25)
                .WithParent(parent)
                .WithName("right")
                .WithDisplayName("Scroll Right")
                .WithShortDisplayName("Scroll Right")
                .WithLayout(kAxisLayout)
                .IsSynthetic(true)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 16,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousescrollright;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousescrollx = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMousescrollx.Setup()
                .At(this, 26)
                .WithParent(parent)
                .WithName("x")
                .WithDisplayName("Scroll Left/Right")
                .WithShortDisplayName("Scroll Left/Right")
                .WithLayout(kAxisLayout)
                .WithUsages(2, 1)
                .WithAliases(0, 1)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 16,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousescrollx;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMousescrolly = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMousescrolly.Setup()
                .At(this, 27)
                .WithParent(parent)
                .WithName("y")
                .WithDisplayName("Scroll Up/Down")
                .WithShortDisplayName("Scroll Wheel")
                .WithLayout(kAxisLayout)
                .WithUsages(3, 1)
                .WithAliases(1, 1)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 20,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMousescrolly;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMouseradiusx = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMouseradiusx.Setup()
                .At(this, 28)
                .WithParent(parent)
                .WithName("x")
                .WithDisplayName("Radius X")
                .WithShortDisplayName("Radius X")
                .WithLayout(kAxisLayout)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 40,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMouseradiusx;
        }

        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent)
        {
            var ctrlMouseradiusy = new UnityEngine.InputSystem.Controls.AxisControl();
            ctrlMouseradiusy.Setup()
                .At(this, 29)
                .WithParent(parent)
                .WithName("y")
                .WithDisplayName("Radius Y")
                .WithShortDisplayName("Radius Y")
                .WithLayout(kAxisLayout)
                .WithStateBlock(new InputStateBlock
                {
                    format = new FourCC(1179407392),
                    byteOffset = 44,
                    bitOffset = 0,
                    sizeInBits = 32
                })
                .Finish();
            return ctrlMouseradiusy;
        }
    }
}
