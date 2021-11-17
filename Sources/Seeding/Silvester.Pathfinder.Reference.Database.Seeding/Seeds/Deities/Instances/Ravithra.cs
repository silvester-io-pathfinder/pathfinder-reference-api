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
    public class Ravithra : Template
    {
        public static readonly Guid ID = Guid.Parse("64511404-5fab-480f-a909-79c317fbb690");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Ravithra",
                Edicts = "Enforce karma's pitiless judgment, shame fools, kill traitors, pursue the Chalice of Amrit.",
                Anathema = "Make decisions erratically or randomly, provide aid to Vasaghati or her followers, engage in treachery.",
                Title = "The Mother of Nagas",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("be9844a7-2417-49f6-9e2b-d2acd1b15dba"), Type = TextBlockType.Text, Text = "The Mother of Nagas, the Karmic Pillar, and the Chalice-Bearer of the danavas, Ravithra was decapitated and brought low by treachery. She grants boons only to mortal champions who seek to topple the treacherous and to restore her to her rightful role." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("4903f0e4-dc27-4f74-b076-38cb083b65ba"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("ede39358-fc90-4457-a8c6-aa4298422166"), Spells.Instances.AnimalForm.ID);
            builder.GainSpecificSpell(Guid.Parse("8ff16db4-5a12-4067-b633-d2d0f1f88c8c"), Spells.Instances.Clairvoyance.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.LightMace.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            
            yield return UnarmedWeapons.Instances.Jaws.ID;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Naga.ID;
            yield return Domains.Instances.Sorrow.ID;
            yield return Domains.Instances.Truth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b317a47-be66-4f35-b38a-dadaa3d398bf"),
                SourceId = Sources.Instances.Pathfinder161.ID,
                Page = 75
            };
        }
    }
}
