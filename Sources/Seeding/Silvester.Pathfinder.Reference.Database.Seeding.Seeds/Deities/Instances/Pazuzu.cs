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
    public class Pazuzu : Template
    {
        public static readonly Guid ID = Guid.Parse("11dd4fba-fdf7-4d69-8db0-10131ef1a004");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Pazuzu",
                Edicts = "Tempt others to immoral acts, revel in flight, possess or magically influence others to cause calamities.",
                Anathema = "Deny a flying creature the ability to ﬂy, abuse Pazuzu's name or call on Pazuzu for help, aid worshippers of.",
                Title = "King of the Wind Demons",
                AreasOfConcern = "The sky, temptation, and winged creatures.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("d7c0a3ae-6af5-4d67-9b41-3beb69e2592b"), Type = TextBlockType.Text, Text = "Pazuzu, King of the Wind Demons, is the demon lord of the sky, temptation, and winged creatures. He counts himself among the most ancient of demon lords, though his constant warring withLamashtuhas hindered his accumulation of power to the point of denying him godhood. He is exceptionally active in meddling in mortal affairs and takes great pleasure in possessing and corrupting good-hearted folk who invoke his name. Pazuzu appears as a humanoid figure with eagle's talons, two pairs of bird wings, a scorpion tail, and an avian demonic head. He is worshipped by harpies, other evil winged creatures, and by countless champions and clerics who fell from grace at his temptations." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("962e0d9c-23fc-4bcf-8973-ee6c53d3aa6e"), Spells.Instances.GustOfWind.ID);
            builder.GainSpecificSpell(Guid.Parse("f0c62a4d-954a-40df-8e19-d5ce40c49637"), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse("193809d7-7897-4980-951e-7325ef6ca0c8"), Spells.Instances.Fly.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Longsword.ID;
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
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Swarm.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("37c5fdfb-b221-430b-af9f-0b63750f8208"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
