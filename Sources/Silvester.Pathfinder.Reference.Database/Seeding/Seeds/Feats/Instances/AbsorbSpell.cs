using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AbsorbSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("89bf6667-358d-4969-b352-2ae9629bf5c3");

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
            yield return new TextBlock { Id = Guid.Parse("75b1d749-8d67-461c-a035-35f344acbd2c"), Type = TextBlockType.Text, Text = "You absorb a spell and store it in your body. If you are a spontaneous spellcaster, you can cast the triggering spell once during the next 10 minutes, even if it’s not on your spell list as if it were in your repertoire. If you are a prepared spellcaster, you can replace one of your prepared spells of the same level with the absorbed spell, but you must cast the absorbed spell within 10 minutes or you lose that spell slot for the day. You cast the spell at the same spell level as the spell you absorbed, but the spell is of your magical tradition and uses your spell DC, spell attack roll, and other statistics to determine its effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c2370ac7-acae-4b71-aa2d-3906fe276d2d"), Feats.Instances.SpellmasterDedication.ID);
            builder.HaveAnyMagicTradition(Guid.Parse("1282f6ba-d86b-4ee9-843e-cc4586172f53"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c65fee46-0bff-4942-bf5a-44473bc3229e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
