using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AccurateFlurry : Template
    {
        public static readonly Guid ID = Guid.Parse("6a33845b-7470-40f0-8fc0-d34f2c4d6d07");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accurate Flurry",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2af5569a-d094-43af-a97d-d78f6bdd2508"), Type = TextBlockType.Text, Text = $"You refine the precision of your unbelievable storm of blows. When you perform an {ToMarkdownLink<Models.Entities.Feat>("Impossible Flurry", Feats.Instances.ImpossibleFlurry.ID)}, your first attack with each weapon instead takes the multiple attack penalty as though you had already made one attack this turn. All subsequent attacks take the maximum multiple attack penalty, as though you had already made two or more attacks this turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("82f78a6d-c1bb-49f1-b147-79009d43e040"), Feats.Instances.ImpossibleFlurry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1aedf162-6529-4927-959f-e7f89c61c79f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
