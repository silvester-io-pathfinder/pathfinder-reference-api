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
    public class SkyKeepers : Template
    {
        public static readonly Guid ID = Guid.Parse("8ab4c56c-51c1-4390-88f7-8d5908f5dfa5");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Sky Keepers",
                Edicts = "Remove anyone that would threaten those who live among the skies, encourage others to find a way to live among the clouds, honor the might of storms.",
                Anathema = "Interfere with the natural phases of the sky, remove a creature's innate means to fly.",
                
                AreasOfConcern = "Freedom, skies, storms, weather.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("113aaf14-c8aa-41fb-8ae5-8eaad10eaca5"), Type = TextBlockType.Text, Text = "The only thing more expansive than the Mwangi jungles, mountains, and rivers are the skies that rest above them. There are many who would seek to take control of the skies and there are others who seek to keep the skies free for all. From evil spellcasters looking to wield the weather for their own wicked whims to deadly monsters that make them dangerous to travel, the skies are never truly safe. Thankfully, an unlikely alliance of gods works together to keep the skies over the Expanse safe." };
            yield return new TextBlock { Id = Guid.Parse("e148326b-a802-4433-9bb7-a84ff535dca9"), Type = TextBlockType.Text, Text = "Apsu, god of good dragons, saw how his sonDahakonce tried to burn down the entirety of the Mwangi Expanse and took it upon himself to defend the skies that rest over those that put a stop to Dahak's destruction.Uvuko, the diamond ring, is a living embodiment of the Mwangi skies and valued Apsu's aid. Finally, with the recent release ofRanginori, the elemental lord took to reclaiming the skies from evildoers. When the three gods encountered each other, they formed the Pact of the Sky Keepers, dedicating themselves to both keeping the skies safe for all, but also maintaining the natural cycles and orders of the skies. The sky belongs to everyone, but ultimately, the sky has no master and attempts to force one's will upon by forcibly changing the weather or committing similar acts goes against the Pact. Followers of the Sky Keepers can be found all over Golarion, but Apsu and Uvuko's focus on the Mwangi Expanse leads to many worshippers operating in the region." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("929dcbf1-8f5b-45b6-b020-847149b66727"), Spells.Instances.GustOfWind.ID);
            builder.GainSpecificSpell(Guid.Parse("56cd0663-dc43-48ea-9970-753f192065d2"), Spells.Instances.Fly.ID);
            builder.GainSpecificSpell(Guid.Parse("91a5c84e-92fd-4d0d-80da-e7045451f57e"), Spells.Instances.StormOfVengeance.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return Items.RangedWeapons.Instances.Longbow.ID;
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
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Protection.ID;
            yield return Domains.Instances.Wyrmkin.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("499a6def-31e9-4565-9d03-59e8ef194bd6"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 0
            };
        }
    }
}
