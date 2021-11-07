using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestralWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("cfc29af5-9df2-40a5-b26d-5ddc230ae6fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestral Weaponry",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b836c83-46f4-41ef-a4b9-5c3a46684024"), Type = TextBlockType.Text, Text = "You blend monastic techniques with the ancestral fighting styles of your people. Choose an ancestry for which you have access to all weapons with that trait. For you, melee weapons with that ancestry trait and either the (trait: agile) or (trait: finesse) trait gain the (trait: monk | Monk - Item) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f0c63da0-dbf6-4be2-981d-ed2f62dc54d5"), Feats.Instances.MonasticWeaponry.ID);
            builder.Manual(Guid.Parse("8e5ec7d8-2b86-41c3-be25-2837fb0fb740"), "A feat granting access to all weapons with an ancestry trait.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66b54ae3-0b87-48fe-a150-d4b6a89462b3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
