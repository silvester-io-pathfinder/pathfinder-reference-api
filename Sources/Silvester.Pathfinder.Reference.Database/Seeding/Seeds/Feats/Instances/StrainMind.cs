using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrainMind : Template
    {
        public static readonly Guid ID = Guid.Parse("fe8444e2-c817-4857-9089-641985b084ad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strain Mind",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You cast a psi cantrip.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("098f0c09-3a50-46b4-8f71-6ed92953b0ef"), Type = TextBlockType.Text, Text = "You strain your body beyond its limits to use an amp even when your mental power is depleted. You apply an amp you know to the spell. Instead of paying the normal Focus Point cost, you lose Hit Points equal to double the level of the amped psi cantrip as you bleed from your nose or suffer some other visible sign of strain." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46348021-53f5-41a8-8d9a-fcb6e66f6643"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
