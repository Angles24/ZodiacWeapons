using Buddy.Coroutines;
using Clio.Utilities;
using Clio.XmlEngine;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.Objects;
using ff14bot.RemoteWindows;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using TreeSharp;
using Action = TreeSharp.Action;

namespace ff14bot.NeoProfiles.Tags
{
    [XmlElement("ZodiacExchange")]
    public class ZodiacExchange : ProfileBehavior
    {
        public override bool HighPriority
        {
            get
            {
                return true;
            }
        }

        protected bool IsDoneOverride;

        public override bool IsDone => IsDoneOverride;

        public override string StatusText
        {
            get
            {
                return $"Some String Here";
            }
        }

        [XmlAttribute("DialogOption")]
        public int DialogOption { get; set; }

        public override Composite CustomLogic
        {
            get
            {
                return
                    new ActionRunCoroutine(async r =>
                    {
                        f14bot.Managers.GameObjectManager.GetObjectByNPCId(2002555).Interact();
                        await Coroutine.Wait(2000, RaptureAtkUnitManager.GetWindowByName("ShopExchangeItem") != null && RaptureAtkUnitManager.GetWindowByName("ShopExchangeItem").IsOpen);
                        RaptureAtkUnitManager.GetWindowByName("ShopExchangeItem").SendAction(2, 0, 0, 1, DialogOption);
                        await Coroutine.Wait(2000, RaptureAtkUnitManager.GetWindowByName("ShopExchangeItemDialog") != null && RaptureAtkUnitManager.GetWindowByName("ShopExchangeItemDialog").IsOpen);
                        RaptureAtkUnitManager.GetWindowByName("ShopExchangeItemDialog").SendAction(1, 0, 0);
                        await Coroutine.Wait(2000, Request.IsOpen);

                        await CommonTasks.HandOverRequestedItems(true);

                        await Buddy.Coroutines.Coroutine.Sleep(120);
                        if (Request.IsOpen)
                            Request.HandOver();
                        IsDoneOverride = true;
                    });
            }
        }
    }
}