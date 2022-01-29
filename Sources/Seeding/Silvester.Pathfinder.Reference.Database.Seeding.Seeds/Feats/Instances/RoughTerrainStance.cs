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
    public class RoughTerrainStance : Template
    {
        public static readonly Guid ID = Guid.Parse("e7f26eb6-13c0-4e13-8e17-0d9b19ade004");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rough Terrain Stance",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85a64a0d-ca09-4738-8658-14f85542477d"), Type = TextBlockType.Text, Text = $"You enter a stance that makes it difficult to move around you. Each square adjacent to you becomes difficult terrain that matches the terrain attunement you gained (rime forms in an arctic terrain, momentary undergrowth shoots up in a forest terrain, and so on). You ignore this difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("e8ebe8f8-840e-41dd-aed9-15b51eccb11a"), Type = TextBlockType.Text, Text = $"This stance ends if you move into a different type of terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("140a07f3-8277-4675-8e02-f0b2febcb996"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("29c55d9d-f988-43d8-bc34-c29a3565c766"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9dbf2623-6aec-4ad5-8213-f8b379457815"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
