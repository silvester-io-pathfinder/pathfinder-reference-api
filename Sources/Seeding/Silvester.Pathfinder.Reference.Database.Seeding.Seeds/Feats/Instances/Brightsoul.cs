using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Brightsoul : Template
    {
        public static readonly Guid ID = Guid.Parse("8242e139-ba1d-47f6-b8b8-1e7a25dac69e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brightsoul",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a47256e4-a3f3-498b-a3a4-376e6e392fc0"), Type = TextBlockType.Text, Text = $"The fire inside you asserts itself as beaming, radiant light. Your body is naturally luminescent, glowing with the effects of a primal {ToMarkdownLink<Models.Entities.Spell>("light", Spells.Instances.Light.ID)} cantrip. A cantrip is heightened to a spell level equal to half your level rounded up. The light is involuntary and constant; if counteracted, it returns in 1d4 rounds. You suffer a -2 circumstance penalty on Stealth checks to {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} and gain a +1 circumstance bonus on saves against {ToMarkdownLink<Models.Entities.Trait>("light", Traits.Instances.Light.ID)} effects and effects that inflict the blinded or dazzled conditions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("783ccd2b-0f20-4fc4-b027-4e085b0d2d13"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
