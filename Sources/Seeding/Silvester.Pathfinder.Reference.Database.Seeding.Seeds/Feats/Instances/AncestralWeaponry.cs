using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestralWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("6fb7042c-acf0-41e6-8221-dbe8c39a6877");

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
            yield return new TextBlock { Id = Guid.Parse("0e036b80-df01-411c-989c-537e3ae6688b"), Type = TextBlockType.Text, Text = $"You blend monastic techniques with the ancestral fighting styles of your people. Choose an ancestry for which you have access to all weapons with that trait. For you, melee weapons with that ancestry trait and either the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} or {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} trait gain the {ToMarkdownLink<Models.Entities.Trait>("monk", Traits.Instances.Monk.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fafd67c5-de4f-467f-b402-f45de349e22e"), Feats.Instances.MonasticWeaponry.ID);
            builder.Manual(Guid.Parse("357bcd07-4fd8-4fa2-a4f4-eb46f36be52b"), "A feat granting access to all weapons with an ancestry trait.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df2de868-0af9-4a10-afd2-4e9efca368a4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
