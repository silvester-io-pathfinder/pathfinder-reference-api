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
    public class WideOverwatch : Template
    {
        public static readonly Guid ID = Guid.Parse("277be9d6-fd94-4a8c-944d-9435cb5cb538");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wide Overwatch",
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
            yield return new TextBlock { Id = Guid.Parse("2a4a381f-a6ad-4d21-970f-3b43d4173a46"), Type = TextBlockType.Text, Text = $"Through a variety of perceptive techniques, careful routines, and upgrades to your enhanced visual gear, you have become able to observe and maintain your overwatch at a much greater distance. Increase the size of your overwatch field from 30 feet to 60 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("88416f05-a805-4435-ac30-f6291757b65e"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("66858a64-94ae-40d7-9be0-b3c6cc93fb43"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad1ecb6b-a030-4b43-9ffc-bbeb62a67a82"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
