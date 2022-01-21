using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellmastersTenacity : Template
    {
        public static readonly Guid ID = Guid.Parse("8658505c-8231-4174-9fec-013008d8c708");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellmaster's Tenacity",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically fail at a saving throw against a foe's spell, and that spell was cast or created with the tradition of magic you selected with the Spellmaster's Resilience feat.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d41288a-6672-435f-accb-d8bec9bf638f"), Type = TextBlockType.Text, Text = "You call upon the power of your spells to protect you from the worst of the magic headed your way. You fail your saving throw instead of critically failing. For 1 minute, increase the circumstance bonus to saving throws from the (feat: Spellmaster's Resilience) feat to +2, and increase the resistance to damage it grants to 10." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("13e63f83-ad69-4fab-84d1-55cb82ffa5d0"), Feats.Instances.SpellmastersResilience.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("908f09d7-e811-4697-bf08-7095a11ecfd7"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
