using NUnit.Framework;
using System;

using LunarAssertsInternal;

namespace Test
{
    using Assert = NUnit.Framework.Assert;

    [TestFixture]
    public class AssertUtilsTest
    {
        [Test]
        public void TestExtractStackTrace()
        {
            string stackTrace = "LunarAssertsInternal.AssertUtils:ExtractStackTrace(Int32) (at Assets/LunarAssert/AssertUtils.cs:19)\n" +
                "Assert:AssertHelper(String, Object[]) (at Assets/LunarAssert/Assert.cs:2033)\n" +
                "Assert:Fail(String) (at Assets/LunarAssert/Assert.cs:1549)\n" +
                "ButtonHandler:OnSingleAssertClick() (at Assets/Scripts/ButtonHandler.cs:17)\n" +
                "UnityEngine.Events.InvokableCall:Invoke(Object[])\n" +
                "UnityEngine.Events.InvokableCallList:Invoke(Object[])\n" +
                "UnityEngine.Events.UnityEventBase:Invoke(Object[])\n" +
                "UnityEngine.Events.UnityEvent:Invoke()\n" +
                "UnityEngine.UI.Button:Press() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/UI/Core/Button.cs:35)\n" +
                "UnityEngine.UI.Button:OnPointerClick(PointerEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/UI/Core/Button.cs:44)\n" +
                "UnityEngine.EventSystems.ExecuteEvents:Execute(IPointerClickHandler, BaseEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/ExecuteEvents.cs:52)\n" +
                "UnityEngine.EventSystems.ExecuteEvents:Execute(GameObject, BaseEventData, EventFunction`1) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/ExecuteEvents.cs:269)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMousePress(MouseButtonEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:378)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMouseEvent(Int32) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:277)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMouseEvent() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:265)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:Process() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:179)\n" +
                "UnityEngine.EventSystems.EventSystem:Update() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/EventSystem.cs:277)\n";

            string expected = "ButtonHandler:OnSingleAssertClick() (at Assets/Scripts/ButtonHandler.cs:17)\n" +
                "UnityEngine.Events.InvokableCall:Invoke(Object[])\n" +
                "UnityEngine.Events.InvokableCallList:Invoke(Object[])\n" +
                "UnityEngine.Events.UnityEventBase:Invoke(Object[])\n" +
                "UnityEngine.Events.UnityEvent:Invoke()\n" +
                "UnityEngine.UI.Button:Press() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/UI/Core/Button.cs:35)\n" +
                "UnityEngine.UI.Button:OnPointerClick(PointerEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/UI/Core/Button.cs:44)\n" +
                "UnityEngine.EventSystems.ExecuteEvents:Execute(IPointerClickHandler, BaseEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/ExecuteEvents.cs:52)\n" +
                "UnityEngine.EventSystems.ExecuteEvents:Execute(GameObject, BaseEventData, EventFunction`1) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/ExecuteEvents.cs:269)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMousePress(MouseButtonEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:378)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMouseEvent(Int32) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:277)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMouseEvent() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:265)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:Process() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:179)\n" +
                "UnityEngine.EventSystems.EventSystem:Update() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/EventSystem.cs:277)\n";

            Assert.AreEqual(expected, AssertUtils.ExtractStackTrace(stackTrace, 3));
        }

        [Test]
        public void TestTryExtractSourceFileInfo()
        {
            string stackTrace = "ButtonHandler:OnSingleAssertClick() (at Assets/Scripts/ButtonHandler.cs:17)\n" +
                "UnityEngine.Events.InvokableCall:Invoke(Object[])\n" +
                "UnityEngine.Events.InvokableCallList:Invoke(Object[])\n" +
                "UnityEngine.Events.UnityEventBase:Invoke(Object[])\n" +
                "UnityEngine.Events.UnityEvent:Invoke()\n" +
                "UnityEngine.UI.Button:Press() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/UI/Core/Button.cs:35)\n" +
                "UnityEngine.UI.Button:OnPointerClick(PointerEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/UI/Core/Button.cs:44)\n" +
                "UnityEngine.EventSystems.ExecuteEvents:Execute(IPointerClickHandler, BaseEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/ExecuteEvents.cs:52)\n" +
                "UnityEngine.EventSystems.ExecuteEvents:Execute(GameObject, BaseEventData, EventFunction`1) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/ExecuteEvents.cs:269)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMousePress(MouseButtonEventData) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:378)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMouseEvent(Int32) (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:277)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:ProcessMouseEvent() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:265)\n" +
                "UnityEngine.EventSystems.StandaloneInputModule:Process() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/InputModules/StandaloneInputModule.cs:179)\n" +
                "UnityEngine.EventSystems.EventSystem:Update() (at /Users/builduser/buildslave/unity/build/Extensions/guisystem/UnityEngine.UI/EventSystem/EventSystem.cs:277)\n";

            SourceFileInfo info;
            Assert.IsTrue(AssertUtils.TryExtractSourceFileInfo(stackTrace, out info));
            Assert.AreEqual("Assets/Scripts/ButtonHandler.cs", info.path);
            Assert.AreEqual(17, info.line);
        }
    }
}