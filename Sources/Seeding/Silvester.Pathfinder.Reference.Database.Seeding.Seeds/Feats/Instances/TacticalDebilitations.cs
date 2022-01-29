using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TacticalDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("1e9e9641-1d8b-4db4-8d74-deb0d000f18e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tactical Debilitations",
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
            yield return new TextBlock { Id = Guid.Parse("e608f218-895f-4a50-b158-70b48c3da7a1"), Type = TextBlockType.Text, Text = $"You learn new debilitations that grant you tactical advantages against your foes. Add the following debilitations to the list you can choose from when you use {ToMarkdownLink<Models.Entities.Feat>("Debilitating Strike", Feats.Instances.DebilitatingStrike.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("5e0b7f89-342f-4373-8266-c9c72e807091"), Type = TextBlockType.Enumeration, Text = $" Debilitation: The target can't use reactions." };
            yield return new TextBlock { Id = Guid.Parse("e5872cb9-d98f-417a-8cb0-1c52ad049fa5"), Type = TextBlockType.Enumeration, Text = $" Debilitation: The target can't flank or contribute to allies' flanking." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("96a36a0d-fc05-4a73-90ad-83582699da96"), Rackets.Instances.Scoundrel.ID);
            builder.HaveSpecificFeat(Guid.Parse("4dc63cf7-2b16-420a-beff-b1d21f8537cd"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08ba665c-65e6-4c90-99b9-2e128b56d60a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
