using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DemonbaneWarrior : Template
    {
        public static readonly Guid ID = Guid.Parse("5e1df12c-3fa6-4852-8a94-dc54e4f8b4d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demonbane Warrior",
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
            yield return new TextBlock { Id = Guid.Parse("62de5011-2aeb-4c53-91ab-ffcfb1ab7172"), Type = TextBlockType.Text, Text = "You gain a +1 circumstance bonus to damage with weapons and unarmed attacks against demons. If your attack would deal more than one weapon die of damage (as is common at higher levels than 1st), the bonus is equal to the number of weapon dice or unarmed attack dice. If your actions force a demon to take damage from its sin vulnerability, increase that damage by 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a270ee8-1460-4d19-a883-124af845ebef"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
