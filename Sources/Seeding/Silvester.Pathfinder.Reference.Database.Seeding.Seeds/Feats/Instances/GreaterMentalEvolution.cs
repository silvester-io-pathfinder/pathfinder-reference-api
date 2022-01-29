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
    public class GreaterMentalEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("4416ff2b-25b6-4dbd-861e-26611e237ac0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Mental Evolution",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c3ca160-b48d-45a0-8e35-624f90873b8e"), Type = TextBlockType.Text, Text = $"Your bloodline's deep connection to mental essence greatly enhances your spell repertoire. Add one spell to your spell repertoire for each spell level you can cast." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("0214e2cb-c56f-4472-b900-0e6f5d458aa9"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("f447c0b8-d077-4c54-8cf6-649b194cde54"), Feats.Instances.ArcaneEvolution.ID);
                or.HaveSpecificFeat(Guid.Parse("8f3fc7a4-9217-46d5-a9b3-0d6c9c88f20e"), Feats.Instances.OccultEvolution.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f601ef71-6d1b-4d5c-bc4a-de5401bbfc46"), Traits.Instances.Sorcerer.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7239d984-5ffa-494f-b243-d5a6f6751b77"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
