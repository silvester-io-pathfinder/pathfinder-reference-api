using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreciseDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("47c96077-b8a2-4023-adfb-73198d7fc4fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Precise Debilitations",
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
            yield return new TextBlock { Id = Guid.Parse("fc2a09cd-107d-4e44-8121-7a01e3331273"), Type = TextBlockType.Text, Text = "You carefully aim and gracefully deliver your debilitations. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("4561528e-4936-45f4-9f9d-fbabcebad673"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target takes an additional 2d6 precision damage from your attacks." };
            yield return new TextBlock { Id = Guid.Parse("4d29569a-08ed-495a-b8b9-02b1fb850bd5"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target becomes flat-footed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("e81709c1-8f72-43b9-85a3-23298cb88401"), Rackets.Instances.Thief.ID);
            builder.HaveSpecificFeat(Guid.Parse("238eb09e-a3ad-425f-bf8a-ce81a490f57a"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d12b5643-2b66-417c-8eec-e1b96c05db86"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
