using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoostModulation : Template
    {
        public static readonly Guid ID = Guid.Parse("ebe4bda4-e3a8-42ff-b781-88d7eb52f25f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boost Modulation",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c3d3ded-1e39-4cc3-84cc-2ea010a68e30"), Type = TextBlockType.Text, Text = $"You aren't satisfied with keeping to just one kind of boost from your constant tinkering, so you've learned to modulate between several possibilities at once. Choose two additional offensive boosts (G&amp;G pg. 22). You can use an {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action to change the offensive boost currently affecting your weapon, choosing between the one you chose for the class feature and the two you chose for this modification. If your weapon has the {ToMarkdownLink<Models.Entities.Trait>("modular", Traits.Instances.Modular.ID)} trait, you can swap the offensive boost as part of the {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action you take to use that trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("150adda8-7e78-4611-a525-f037bfd285bb"), ClassFeatures.Inventors.OffensiveBoost.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d03ae6f-5fba-4ce1-8a42-88da0d733c82"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
