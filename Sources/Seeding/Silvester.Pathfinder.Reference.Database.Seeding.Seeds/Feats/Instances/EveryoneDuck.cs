using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EveryoneDuck : Template
    {
        public static readonly Guid ID = Guid.Parse("92734573-9547-4cc9-85cd-ab3c96f78048");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Everyone Duck!",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail, but don't critically fail, an attempt to Disable a Device on a trap.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7113c213-5ead-4582-a710-e35edd4884c8"), Type = TextBlockType.Text, Text = $"You intentionally set off the trap, but you take special precautions to protect yourself and your allies from the trap's effects. For the next 2 rounds, if the trap rolls a critical success on an attack roll, it gets a normal success instead, and if anyone rolls a critical failure on their saving throw against the trap, they get a normal failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1b619aa3-4c3e-41cd-ad1d-0aab6d01df4c"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1720a7ef-5eea-471b-a97f-6a1268217038"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
