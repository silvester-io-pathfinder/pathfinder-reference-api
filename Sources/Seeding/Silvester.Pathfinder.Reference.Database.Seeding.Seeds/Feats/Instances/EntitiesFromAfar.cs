using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EntitiesFromAfar : Template
    {
        public static readonly Guid ID = Guid.Parse("e3f31651-5d15-45e2-8f52-4df41ea20655");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Entities from Afar",
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
            yield return new TextBlock { Id = Guid.Parse("893ed462-e2bb-42c5-860c-2b2b33d232bf"), Type = TextBlockType.Text, Text = $"You can call in aberrations to fight for you or to answer questions. You can cast {ToMarkdownLink<Models.Entities.Spell>("summon entity", Spells.Instances.SummonEntity.ID)} as an innate occult spell once per day. If you couldn't already cast occult spells, these spells use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for occult spells; if you could already cast occult spells, your proficiency in spell attack rolls and spell DCs for occult spells increases to expert." };
            yield return new TextBlock { Id = Guid.Parse("830bbdbd-7e2e-41b5-954a-dbcc549d7686"), Type = TextBlockType.Text, Text = $"As soon as the aberration arrives, instead of giving it any other commands, you can demand that it help you with a single question you pose to it. For the creature to effectively answer, you must {ToMarkdownLink<Models.Entities.Action>("Sustain the Spell", Actions.Instances.SustainASpell.ID)} for 1 minute, and you must understand and be understood by the aberration. If you do, the aberration gives you a cryptic clue as provided by the {ToMarkdownLink<Models.Entities.Spell>("read omens", Spells.Instances.ReadOmens.ID)} spell, except that the clue is even more enigmatic than normal; the creature then immediately returns from whence it came without providing you any other benefit. At 16th level and every 2 levels thereafter, the {ToMarkdownLink<Models.Entities.Spell>("summon entity", Spells.Instances.SummonEntity.ID)} spell is heightened by 1 level (to a maximum of 8th level when you reach 20th level)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6b80b4e8-bfce-40e3-afbd-3118ec3001e0"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f52e1f42-dd3a-439c-8ceb-bbf6a85a724e"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
