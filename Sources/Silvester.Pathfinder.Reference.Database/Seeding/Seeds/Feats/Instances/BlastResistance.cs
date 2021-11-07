using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlastResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("8d56f993-bbcb-4ea1-8ce4-1728af0dd77d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blast Resistance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("535864e2-b013-4465-ab85-5c19679ef64f"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("da75c3e8-7398-4d3e-b7d9-9ab3ef97cbc1"), Type = TextBlockType.Text, Text = "You’re used to the clamor of steel, the crack of a firearm, and the thunderous blast of explosions. You gain resistance 3 to sonic. If you roll a success on a saving throw against an (trait: auditory) effect that causes the deafened condition, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43a1827a-abd2-431c-82e5-ae9722f90853"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
