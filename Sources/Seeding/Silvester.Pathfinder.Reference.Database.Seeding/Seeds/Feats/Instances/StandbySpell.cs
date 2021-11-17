using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StandbySpell : Template
    {
        public static readonly Guid ID = Guid.Parse("e361a8eb-d733-4b4c-8e98-2c1095d9fa9b");

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
            yield return new TextBlock { Id = Guid.Parse("c81a25b2-5880-4fe1-a4cb-87693c2005a8"), Type = TextBlockType.Text, Text = "You’ve honed one spell as your favored combat technique, and you’ve practiced it enough that you no longer need to prepare it to cast it. Choose a spell in your (item: spellbook) that you could use with (feat: Spellstrike) and that has a level no higher than the highest-level magus spell slot you have. You can (action: Cast this Spell | Cast a Spell) without having it prepared ahead of time by expending a spell slot of a sufficient level to cast your chosen spell. You can change this spell whenever you add new spells to your (item: spellbook), or by studying your (item: spellbook) for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4323f2dd-951a-4e41-a547-bee4d706da67"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1d0dac8-fa4c-4a28-9973-eceaebfd670b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}