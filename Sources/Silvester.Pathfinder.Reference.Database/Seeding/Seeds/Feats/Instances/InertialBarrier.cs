using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InertialBarrier : Template
    {
        public static readonly Guid ID = Guid.Parse("622c9acd-7efd-4a91-8bac-784ee9069141");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inertial Barrier",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41c3f921-7246-468a-8773-b8a64dbf7c8f"), Type = TextBlockType.Text, Text = "Your spell leaves behind barriers that reduce shock and motion. Use this amp in place of the psi cantrip’s normal amp entry." };
            yield return new TextBlock { Id = Guid.Parse("3d67ba1c-a3d6-4489-9e40-e0202d0df867"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("f2d42faa-62d2-4283-86f4-bf7f95e4a353"), Type = TextBlockType.Text, Text = "~ Amp: You or one target of the spell gain resistance to physical damage equal to 2 + the spell’s level until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3bd2de96-3ca8-4220-9852-ef961f0f8380"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
