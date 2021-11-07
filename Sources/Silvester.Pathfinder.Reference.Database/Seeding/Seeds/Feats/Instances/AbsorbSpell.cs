using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AbsorbSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("5589e941-f503-4d2c-b6fe-913315e3b3e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Absorb Spell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically succeed at a saving throw against a foe's spell, and that spell is of a level you can normally cast.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("99e0ca24-2e56-4807-b538-3751f072d376"), Type = TextBlockType.Text, Text = "You absorb a spell and store it in your body. If you are a spontaneous spellcaster, you can cast the triggering spell once during the next 10 minutes, even if it’s not on your spell list as if it were in your repertoire. If you are a prepared spellcaster, you can replace one of your prepared spells of the same level with the absorbed spell, but you must cast the absorbed spell within 10 minutes or you lose that spell slot for the day. You cast the spell at the same spell level as the spell you absorbed, but the spell is of your magical tradition and uses your spell DC, spell attack roll, and other statistics to determine its effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dc8766be-87cc-44f2-9d8a-72a8146ce921"), Feats.Instances.SpellmasterDedication.ID);
            builder.HaveAnyMagicTradition(Guid.Parse("e3875082-3915-4764-9d72-cf85e86b0b29"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba24f43b-210e-4f5b-9251-739ac2ffba6c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
