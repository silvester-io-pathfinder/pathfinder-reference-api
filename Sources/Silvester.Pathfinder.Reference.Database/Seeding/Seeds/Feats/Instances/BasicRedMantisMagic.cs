using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicRedMantisMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("a553a4b5-7edb-4e5a-8260-4db44788ffcb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Red Mantis Magic",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7599fca1-ec21-4798-b55b-f95d3eb5b439"), Type = TextBlockType.Text, Text = "You have learned limited divine magic from your Red Mantis training. You gain the (activity: Cast a Spell) activity. You’re a prepared spellcaster, able to prepare two cantrips and one 1st-level spell each day. You prepare these spells from a Red Mantis assassin spellbook, similar to a wizard’s, containing three cantrips and two 1st-level spells. All the spells in your Red Mantis assassin spellbook, from this and later feats, must be either (trait: transmutation) or (trait: illusion) spells from the arcane spell list or a spell from the following list: (spell: clairaudience), (spell: clairvoyance), (spell: darkness), (spell: dimension door), (spell: modify memory), (spell: obscuring mist), (spell: paralyze), (spell: see invisibility), (spell: true strike). Regardless of their usual magical tradition, your Red Mantis assassin spells are divine spells, as are any Red Mantis focus spells you gain." };
            yield return new TextBlock { Id = Guid.Parse("fe8f86fd-9b90-4edc-8ef9-cbebb9fe282e"), Type = TextBlockType.Text, Text = "You can prepare two cantrips and one 1st-level spell each day from those found in your Red Mantis assassin spellbook. You’re trained in spell attack rolls and spell DCs for casting divine spells. Your key spellcasting ability for these spells is Charisma." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("669bdb5a-6a37-45f9-87af-9aa8663ab27e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            builder.HaveSpecificFeat(Guid.Parse("615d3245-e06c-469c-9b04-26f59ddcb187"), Feats.Instances.RedMantisAssassinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19fdd693-4c52-4c4e-b7b6-bc2ef0511753"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
