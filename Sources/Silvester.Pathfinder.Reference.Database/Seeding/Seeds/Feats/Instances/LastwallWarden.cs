using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LastwallWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("1902818e-e4a2-4a5d-9c59-3915a3675610");

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
            yield return new TextBlock { Id = Guid.Parse("15ff7626-855e-4b15-b6ed-573811373639"), Type = TextBlockType.Text, Text = "You use your shield to protect your allies, not just yourself, especially against the undead. When you have a shield raised, you can use your (feat: Shield Block) reaction when an attack is made against an ally adjacent to you, in addition to its usual trigger. If you do, the shield prevents that ally from taking damage instead of you, following the normal rules for a (feat: Shield Block)." };
            yield return new TextBlock { Id = Guid.Parse("81bfb73d-56dc-4c35-bd6d-fa63fd7a54e9"), Type = TextBlockType.Text, Text = "If an undead makes an attack against an ally within 10 feet, you can (action: Step) to become adjacent to your ally and then use (feat: Shield Block) as part of the same reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6ea9e593-d064-452e-a510-f3706f1a1252"), Feats.Instances.LastwallSentryDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ed70e2e-d67c-4d79-b170-f5d7749b931e"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
