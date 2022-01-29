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
    public class ShootingStarsStance : Template
    {
        public static readonly Guid ID = Guid.Parse("795be5f8-24ea-415f-8159-b422171442db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shooting Stars Stance",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("986c41da-6b30-495c-a43c-99290af81d93"), Type = TextBlockType.Text, Text = $"You enter a stance that lets you throw shuriken with lightning speed. While in this stance, you can use your monk feats or monk abilities that normally require unarmed attacks with shuriken instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c3802ee6-99b1-458c-9bdb-9f4ee4d9684a"), Feats.Instances.MonasticWeaponry.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7862866f-c4e4-47a5-bbfc-5a1b4dc1011a"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("604f6e9d-b700-459d-b873-efc18b86dcaa"), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("683500fe-0736-4b48-b3ce-7819de1e3843"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
