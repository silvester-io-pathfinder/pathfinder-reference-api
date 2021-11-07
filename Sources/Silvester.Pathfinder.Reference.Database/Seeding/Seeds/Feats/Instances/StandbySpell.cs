using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StandbySpell : Template
    {
        public static readonly Guid ID = Guid.Parse("9d908e78-a59b-4e60-8147-c3c113b1b351");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Standby Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2b734d5-864d-4ea7-8d92-9d650fbd34b6"), Type = TextBlockType.Text, Text = "You’ve honed one spell as your favored combat technique, and you’ve practiced it enough that you no longer need to prepare it to cast it. Choose a spell in your (item: spellbook) that you could use with (feat: Spellstrike) and that has a level no higher than the highest-level magus spell slot you have. You can (action: Cast this Spell | Cast a Spell) without having it prepared ahead of time by expending a spell slot of a sufficient level to cast your chosen spell. You can change this spell whenever you add new spells to your (item: spellbook), or by studying your (item: spellbook) for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("25560687-29d0-44b7-bd16-6b126b571054"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbdb3e8d-37c1-4acc-be0a-dc003cb523b9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
