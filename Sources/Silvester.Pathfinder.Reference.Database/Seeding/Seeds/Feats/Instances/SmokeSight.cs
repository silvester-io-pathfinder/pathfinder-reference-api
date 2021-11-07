using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmokeSight : Template
    {
        public static readonly Guid ID = Guid.Parse("c49a4e26-066c-4624-a6c1-93451d1b7f05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smoke Sight",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("40d519aa-5cff-4513-a051-8d12bfbbf67b"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("706ddd7b-4bda-4baf-91b1-b3cb62c18e88"), Type = TextBlockType.Text, Text = "You’re used to fighting and hiding in a haze of smoke and flame. You automatically succeed at the DC 5 flat check to target a concealed creature if that creature is concealed only by smoke. When you are concealed or hidden in smoke, increase the DC of the flat check to target you to 6 if you’re concealed or 12 if you’re hidden." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7aad9a63-2312-4242-be93-6a9fdfb050ef"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
