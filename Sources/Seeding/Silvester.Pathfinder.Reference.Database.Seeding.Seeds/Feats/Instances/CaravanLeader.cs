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
    public class CaravanLeader : Template
    {
        public static readonly Guid ID = Guid.Parse("18bfe02a-5f0d-46fc-b34d-e2866e8e6456");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Caravan Leader",
                Level = 11,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7f867f0c-3afe-417c-9384-9041d0303328"), Type = TextBlockType.Text, Text = $"You know how to get the most effort out of your allies on the road. When {ToMarkdownLink<Models.Entities.Activity>("Hustling", Activities.Instances.Hustle.ID)} in a group during exploration mode, your group can {ToMarkdownLink<Models.Entities.Activity>("Hustle", Activities.Instances.Hustle.ID)} for as long as the member who could {ToMarkdownLink<Models.Entities.Activity>("Hustle", Activities.Instances.Hustle.ID)} longest on their own, plus an additional 20 minutes beyond that." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("9f786a37-1249-4caa-84bd-131327ad56f7"), requiredStatValue: 18, Stats.Instances.Constitution.ID);
            builder.HaveSpecificFeat(Guid.Parse("6e4bca50-6ca6-4cfc-8bb8-a2f45c1b7e2b"), Feats.Instances.PickUpThePace.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9be2c11e-fa9a-4d82-b48b-9dc6528b43ba"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
