using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Baalzebul : Template
    {
        public static readonly Guid ID = Guid.Parse("f373d36f-8db5-4150-abe1-b67b17214092");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Archdevils.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Baalzebul",
                Edicts = "Convey yourself with regal dignity, claim what you desire and deserve, seek vengeance from those who wrong you.",
                Anathema = "Provoke Baalzebul's envy, show humility.",
                Title = "Lord of Flies",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("2c4b3e17-fc45-4485-a98d-354a760d9f38"), Type = TextBlockType.Text, Text = "Baalzebul was one of the first angels of Heaven, a glorious lieutenant who followed Asmodeus in his exodus to Hell. In this new realm, he led the infernal armies and trained several other archdevils as generals. When Asmodeus divided the nine realms of Hell between himself and the eight archdevils, Baalzebul protested, thinking he had earned a place at his god's side. Asmodeus responded by stripping away the archdevil's radiant form, reducing him to a figure composed of swarming flies. Now known as the Lord of Flies, he rules over Cocytus, the frozen seventh layer of Hell, and attracts followers possessed of deep ambition and a powerful drive to triumph." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("1eef60a2-55ba-40f9-a025-7c4bbe4a2659"), Spells.Instances.FleetStep.ID);
            builder.GainSpecificSpell(Guid.Parse("dfc440f3-ec35-42ac-b31c-e14e09a2741f"), Spells.Instances.VomitSwarm.ID);
            builder.GainSpecificSpell(Guid.Parse("ec94d125-09d8-454e-bf73-258c0f0fd58a"), Spells.Instances.Mislead.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Spear.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Trickery.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3145ccf-2e6b-424c-9c3b-1650b7a26b24"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
