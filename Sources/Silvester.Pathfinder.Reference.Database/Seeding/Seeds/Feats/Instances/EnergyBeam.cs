using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyBeam : Template
    {
        public static readonly Guid ID = Guid.Parse("2c54cd44-08dd-4a29-b823-3408485df4bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Beam",
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
            yield return new TextBlock { Id = Guid.Parse("fb108679-810e-4eab-8ab7-8808e96f0986"), Type = TextBlockType.Text, Text = "You can channel your core’s power through the magical gem that serves as your eye. You gain an energy beam ranged unarmed attack that deals 1d4 fire damage. The energy beam has a range increment of 20 feet. On a critical hit, the target takes persistent fire damage equal to the number of weapon damage dice. Your energy beam does not add critical specialization effects." };
            yield return new TextBlock { Id = Guid.Parse("d1bd0f74-a7c5-433a-8e0b-8268684a93b8"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("ad5c4fae-3d6f-4e23-8585-2d8dbcc5490e"), Type = TextBlockType.Text, Text = "~ Enhancement: You channel greater power. Increase the damage die of your energy beam by one step, from 1d4 to 1d6." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acd62eb8-6676-4fdb-b4ed-c14f1d9f7f21"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
