using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FireSavvy : Template
    {
        public static readonly Guid ID = Guid.Parse("9b2ac4d9-eb34-4f62-8a0f-485382d08bc2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fire Savvy",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42f475a1-1c80-4f4f-8654-d1dec2698be1"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("8eb23ec4-4a13-444c-9709-226a35612a31"), Type = TextBlockType.Text, Text = "You’ve grown up around a forge and are well-suited to dealing with smoke and flame. Your flat check to remove persistent fire damage is DC 10 instead of DC 15, which is reduced to DC 5 with appropriate assistance. In addition, if you roll a success on a saving throw against suffocation or choking due to smoke or ash, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c3fc172-73b8-401d-b610-36d6963d12c1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
