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
    public class Ydersius : Template
    {
        public static readonly Guid ID = Guid.Parse("2936ab24-89ed-4d1f-be63-678b61b7f30c");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Ydersius",
                Edicts = "Seek to return Ydersius to life, fulfill your passions, conquer your foes with no mercy, achieve glory for serpentkind.",
                Anathema = "Put the needs of others above those of serpentfolk, aid the spawn of Azlant.",
                
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("6e5d68f4-d1c2-442b-af38-2c2ec39e182f"), Type = TextBlockType.Text, Text = "The serpentfolk god is not dead, but in his decapitated state, he might as well be. Reduced to a feral, animalistic existence, Ydersius is even less aware of his legacy than the lowest of the aapoph. Ydersius's symbol is a snake's skull surrounded by a skeletal ouroboros." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("d9c37f8c-7f9d-4f69-9132-1b8a340fcc9a"), Spells.Instances.MagicFang.ID);
            builder.GainSpecificSpell(Guid.Parse("51dd935b-e0e0-4f44-aa21-7652f9cc01e5"), Spells.Instances.Cloudkill.ID);
            builder.GainSpecificSpell(Guid.Parse("909c8b71-8b71-472e-8189-8cb13bafe6af"), Spells.Instances.PurpleWormSting.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Dagger.ID;
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
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("405caf89-ef3d-47c6-9018-02a6ce7ae5c8"),
                SourceId = Sources.Instances.Bestiary2.ID,
                Page = 237
            };
        }
    }
}
