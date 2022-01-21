using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Craft : Template
    {
        public static readonly Guid ID = Guid.Parse("e21b9919-38ad-4758-a378-7bd9b7e8437e");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Craft",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1854383b-6d1b-43e7-853a-c0b7b7ab1406"), Type = TextBlockType.Text, Text = "You can make an item from raw materials. You need the Alchemical Crafting skill feat to create alchemical items, the Magical Crafting skill feat to create magic items, and the Snare Crafting feat to create snares." };
            yield return new TextBlock { Id = Guid.Parse("87555f28-0fd2-4a7e-ac6e-9730514a51bf"), Type = TextBlockType.Text, Text = "To Craft an item, you must meet the following requirements:" };
            yield return new TextBlock { Id = Guid.Parse("7fdcccbe-0702-4a3f-b296-8ab58081189a"), Type = TextBlockType.Enumeration, Text = "The item is your level or lower. An item that doesn�t list a level is level 0. If the item is 9th level or higher, you must be a master in Crafting, and if it�s 16th or higher, you must be legendary." };
            yield return new TextBlock { Id = Guid.Parse("1114215d-472a-4809-b9f4-866991958996"), Type = TextBlockType.Enumeration, Text = "You have the formula for the item; see Getting Formulas below for more information." };
            yield return new TextBlock { Id = Guid.Parse("f6fab90e-1da4-4cb5-959e-8d00e45debab"), Type = TextBlockType.Enumeration, Text = "You have an appropriate set of tools and, in many cases, a workshop. For example, you need access to a smithy to forge a metal shield, or an alchemist�s lab to produce alchemical items." };
            yield return new TextBlock { Id = Guid.Parse("cae1c433-b28a-4af3-b4aa-f3cee920e97b"), Type = TextBlockType.Enumeration, Text = "You must supply raw materials worth at least half the item�s Price. You always expend at least that amount of raw materials when you Craft successfully. If you�re in a settlement, you can usually spend currency to get the amount of raw materials you need, except in the case of rarer precious materials." };
            yield return new TextBlock { Id = Guid.Parse("49778494-0055-4b4e-aab2-9d51dd64fef4"), Type = TextBlockType.Text, Text = "You must spend 4 days at work, at which point you attempt a Crafting check. The GM determines the DC to Craft the item based on its level, rarity, and other circumstances." };
            yield return new TextBlock { Id = Guid.Parse("ddd980da-1c1c-4501-b2d7-6f89cc78cd53"), Type = TextBlockType.Text, Text = "If your attempt to create the item is successful, you expend the raw materials you supplied. You can pay the remaining portion of the item�s Price in materials to complete the item immediately, or you can spend additional downtime days working on it. For each additional day you spend, reduce the value of the materials you need to expend to complete the item. This amount is determined using Table 4�2: Income Earned (page 236), based on your proficiency rank in Crafting and using your own level instead of a task level. After any of these downtime days, you can complete the item by spending the remaining portion of its Price in materials. If the downtime days you spend are interrupted, you can return to finish the item later, continuing where you left off. An example of Crafting appears in the sidebar." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
            yield return Traits.Instances.Manipulate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("8e9ab740-07bc-47ca-a1cf-4395fb531e4a"),
                CriticalSuccess = "Your attempt is successful. Each additional day spent Crafting reduces the materials needed to complete the item by an amount based on your level + 1 and your proficiency rank in Crafting.",
                Success = "Your attempt is successful. Each additional day spent Crafting reduces the materials needed to complete the item by an amount based on your level and your proficiency rank.",
                Failure = "You fail to complete the item. You can salvage the raw materials you supplied for their full value.If you want to try again, you must start over.",
                CriticalFailure = "You fail to complete the item. You ruin 10% of the raw materials you supplied, but you can salvage the rest. If you want to try again, you must start over."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Downtime.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f67a07d-8ff8-40d7-a1b3-4c60b58b3948"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 244
            };
        }
    }
}
