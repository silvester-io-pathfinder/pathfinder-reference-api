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
    public class Doloras : Template
    {
        public static readonly Guid ID = Guid.Parse("a76ada64-38e0-4638-835f-e9e9d88e34f6");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.QueensOfTheNight.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Doloras",
                Edicts = "Push the boundaries of science and suffering, torture other creatures.",
                Anathema = "Show or act on emotion, allow a plea for mercy to sway you.",
                Title = "Our Lady of Pain",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("14a58412-b6fa-4505-8cb1-1e4294d4423f"), Type = TextBlockType.Text, Text = "Perhaps the cruelest of Hell's divinities, the Sadistic Angel shares certain characteristics with the velstracs who once resided in Hell—most notably, a drive to inflict physical pain upon living creatures. She does not inflict her torments out of anger or retribution; she practices her art with an unparalleled detachment and absence of emotion. Her followers are sadists, torturers who relish their grisly work, and those diabolists who summon velstracs rather than devils. While she bears the title of Queen of the Night and commands power commensurate with the others, Our Lady in Pain is content with her station and holds no ambitions beyond ensuring she can continue her tortures uninterrupted." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("6af63f1b-37b4-4c25-8855-9ae71da18fb9"), Spells.Instances.PhantomPain.ID);
            builder.GainSpecificSpell(Guid.Parse("0a2a4669-9c1a-4b4f-9d92-e05b9263d3d5"), Spells.Instances.Earthbind.ID);
            builder.GainSpecificSpell(Guid.Parse("2f486225-0329-449c-ab7a-3135651ee24d"), Spells.Instances.SynapticPulse.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Kukri.ID;
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
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Pain.ID;
            yield return Domains.Instances.Repose.ID;
            yield return Domains.Instances.Sorrow.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("b60255f9-dc76-428c-81e7-5df7a0d4a68b"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
