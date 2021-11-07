using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LastwallWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("41d933ec-b7c1-41b9-b885-2df22272661f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lastwall Warden",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f0aa863-660e-4b2e-9c95-169f0fcf0600"), Type = TextBlockType.Text, Text = "You use your shield to protect your allies, not just yourself, especially against the undead. When you have a shield raised, you can use your (feat: Shield Block) reaction when an attack is made against an ally adjacent to you, in addition to its usual trigger. If you do, the shield prevents that ally from taking damage instead of you, following the normal rules for a (feat: Shield Block)." };
            yield return new TextBlock { Id = Guid.Parse("940f2712-5621-42f1-a1a0-e730d0ebd29b"), Type = TextBlockType.Text, Text = "If an undead makes an attack against an ally within 10 feet, you can (action: Step) to become adjacent to your ally and then use (feat: Shield Block) as part of the same reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("987ad419-15b3-41c8-bcf9-ba981fb06d81"), Feats.Instances.LastwallSentryDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c83825d-c394-4c1a-bb04-1d3cb123b3e9"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
