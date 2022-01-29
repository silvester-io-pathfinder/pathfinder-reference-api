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
    public class NoNoICreatedYou : Template
    {
        public static readonly Guid ID = Guid.Parse("dad0cfa6-cf23-4dbe-ba24-8ae91fcbb42e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No! No! I Created You!",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your construct companion would become confused or controlled.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1e058af-c91d-4d5b-8bfa-d2815a3c2629"), Type = TextBlockType.Text, Text = $"You appeal to your construct companion's bond with its creator to have it break free of a controlling effect. Attempt to counteract the effect that confused or controlled your construct companion, using your Crafting modifier for the counteract check and half your level rounded up for the counteract level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("b3fdc7ea-526d-438b-bd61-4463fe80d0a7"), Innovations.Instances.Construct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("208551f3-d3dd-4ed0-b8cc-cb053d3f0e0b"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("e4990d52-0f18-4070-814c-ab0f06e2df06"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("4e0b3e98-77d0-40b6-b75b-d075cd34174f"), Traits.Instances.Inventor.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bf41acb-2d32-4d12-a537-b1a55ec2420c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
