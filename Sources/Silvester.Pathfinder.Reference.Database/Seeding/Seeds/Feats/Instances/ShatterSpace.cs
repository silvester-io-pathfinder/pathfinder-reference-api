using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShatterSpace : Template
    {
        public static readonly Guid ID = Guid.Parse("d2993e91-66e4-4ad5-acee-1d366c60b6c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shatter Space",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21aa0782-3c6b-4e75-ae1f-1a4bdd5cfdc8"), Type = TextBlockType.Text, Text = "The sheer power of your psychic magic causes fractures in reality. Use this amp in place of the psi cantrip’s normal amp entry." };
            yield return new TextBlock { Id = Guid.Parse("2164f6ca-6aa9-42e1-a505-61c386854b95"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("845edf0a-3630-492e-88d2-3d02c832724d"), Type = TextBlockType.Text, Text = "~ Amp: You or one target of the spell are surrounded in a spiral of torn space. This is an aura in a 5-foot emanation. A creature that starts its turn in the aura takes 1d6 slashing damage for every 2 levels of the amped psi cantrip, with a basic Reflex save against your spell DC. The aura lasts until the beginning of your next turn. You can choose whether the aura affects the creature emitting it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f2777dc-630a-4baf-8e05-eef7bf7570b0"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
