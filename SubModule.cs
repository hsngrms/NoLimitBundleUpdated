using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Party;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;

namespace NoLimitBundleUpdated
    {
    public class SubModule : MBSubModuleBase
        {
        protected override void OnSubModuleLoad()
            {
            base.OnSubModuleLoad();
            new Harmony("hsngrms.nolimit.bundle.updated").PatchAll();
            }
        protected override void OnBeforeInitialModuleScreenSetAsRoot()
            {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            InformationManager.DisplayMessage(new InformationMessage("NoLimitBundleUpdated mod enabled"));
            }
        }

    [HarmonyPatch(typeof(DefaultClanTierModel), "GetCompanionLimit")]
    internal class CompanionLimitOverride
        {
        public static void Postfix(ref int __result)
            {
            try
                {
                __result = 9999;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of CompanionLimitOverride ! "));
                }
            }
        }

    [HarmonyPatch(typeof(DefaultPartySizeLimitModel), "GetPartyMemberSizeLimit")]
    internal class PartyMemberSizeLimitOverride
        {
        public static void Postfix(ref ExplainedNumber __result, PartyBase party)
            {
            ExplainedNumber explainedNumber = new ExplainedNumber(9999f, false, null);
            if (party.IsMobile && party.MobileParty.IsMainParty)
                {
                try
                    {
                    __result = explainedNumber;
                    }
                catch (System.Exception)
                    {
                    InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of PartyMemberSizeLimitOverride ! "));
                    }
                }
            }
        }

    [HarmonyPatch(typeof(DefaultDiplomacyModel), "GetScoreOfClanToJoinKingdom")]
    internal class PartyCountLimitOverrideFix
        {
        public static void Postfix(ref float __result)
            {
            try
                {
                __result = -1f;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of PartyCountLimitOverrideFix ! "));
                }
            }
        }

    [HarmonyPatch(typeof(DefaultClanTierModel), "GetPartyLimitForTier")]
    internal class PartyCountLimitOverride
        {
        public static void Postfix(ref int __result)
            {
            try
                {
                __result = 9999;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of PartyCountLimitOverride ! "));
                }
            }
        }

    [HarmonyPatch(typeof(DefaultPartySizeLimitModel), "GetPartyPrisonerSizeLimit")]
    internal class PartyPrisonerSizeLimitOverride
        {
        public static void Postfix(ref ExplainedNumber __result, PartyBase party)
            {
            ExplainedNumber explainedNumber = new ExplainedNumber(9999f, false, null);
            if (party.IsMobile && party.MobileParty.IsMainParty)
                {
                try
                    {
                    __result = explainedNumber;
                    }
                catch (System.Exception)
                    {
                    InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of PartyPrisonerSizeLimitOverride ! "));
                    }
                }
            }
        }

    [HarmonyPatch(typeof(DefaultWorkshopModel), "GetMaxWorkshopCountForPlayer")]
    internal class MaxWorkshopCountOverride
        {
        public static void Postfix(ref int __result)
            {
            try
                {
                __result = 9999;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of MaxWorkshopCountOverride ! "));
                }
            }
        }

    }