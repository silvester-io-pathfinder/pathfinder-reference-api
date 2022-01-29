using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RangerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("7f4a5856-c197-481f-be30-45d806ebb344");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ranger Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the ranger archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fab0157a-4689-4d27-8d8a-781cd4327f93"), Type = TextBlockType.Text, Text = $"You become trained in Survival; if you were already trained in Survival, you instead become trained in another skill of your choice. You become trained in ranger class DC." };
            yield return new TextBlock { Id = Guid.Parse("0e0ff199-1ce8-4f32-bcee-5c378caddd6a"), Type = TextBlockType.Text, Text = $"You can use the {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)} action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("b089f959-a6be-4e6d-b6fa-d24f2222f492"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04dba1c0-2776-4b81-9ea4-7bd2fdadc0d8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
