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
    public class RedirectElements : Template
    {
        public static readonly Guid ID = Guid.Parse("0ab1d3c6-6c86-416b-9919-19dbaac82be1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Redirect Elements",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "The spell attack roll for a foe's spell with an elemental trait targeting you fails or critically fails.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8fba2e8-268e-43f3-bb90-2cf01a608ab0"), Type = TextBlockType.Text, Text = $"You seize the elemental essence of an incoming spell and redirect the spell to a creature of your choice within the spell's area. The attacker rerolls the spell's attack roll against the new target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eedf26ae-fb50-407f-a724-26533c592417"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae2df59e-4950-4660-ab1e-6a5b8e8ecd88"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
