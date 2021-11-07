using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TacticalDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("b37629f0-68af-4cdb-8f4a-8fe1919998a7");

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
            yield return new TextBlock { Id = Guid.Parse("28737f6c-7c45-4056-9780-8662ee402911"), Type = TextBlockType.Text, Text = "You learn new debilitations that grant you tactical advantages against your foes. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("4e41985f-764e-45bd-9e4e-f55c9273f7e3"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target can’t use reactions." };
            yield return new TextBlock { Id = Guid.Parse("b5890bd6-a11d-480a-9f8f-acde05e26ab1"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target can’t flank or contribute to allies’ flanking." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("14b4848f-5583-4be1-aa1f-c4ab5a25f748"), Rackets.Instances.Scoundrel.ID);
            builder.HaveSpecificFeat(Guid.Parse("fdf14bbe-e535-46da-9f5f-00f6e201b0f1"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e700c533-cca7-435a-a2c3-cdfab71e5868"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
