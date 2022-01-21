using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PortraitOfTheArtist : Template
    {
        public static readonly Guid ID = Guid.Parse("c2159a34-7867-4325-b7fd-ffc59ceb70d9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Portrait of the Artist",
                Level = 5,
                Duration = "1 hour.",
                CastTime = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("449dd539-3d2f-4106-a882-291a45b77acd"), Type = TextBlockType.Text, Text = "You change your appearance to look like a well-known artist talented at a particular craft or performance, such as a painter, singer, or orator, with the effects of illusory disguise. Additionally, you appear to mimic their skill, although such appearances are merely an illusion. If they are famous for physical art, the spell creates illusions of physical artwork matching their style, and onlookers who don�t disbelieve are convinced these works are as impressive as the real thing. If they are famous for their ability to perform, you create an illusory performance that tricks onlookers into thinking you are as skillful as the performer you�re pretending to be. The audience can disbelieve this spell if they interact with your art or actively listen to the performance, using either Perception or an appropriate Lore, whichever is higher. When the duration ends, any fake art disappears, and those who were duped by a performance realize it wasn�t as good as they thought, though they still might not discover that you weren�t really the artist you claimed to be." };
            yield return new TextBlock { Id = Guid.Parse("847b3ec4-ddc4-49cd-8f23-e4ed0b9535a4"), Type = TextBlockType.Text, Text = "This spell can�t grant you any benefits from special abilities that take such skill they require a Performance check, such as the lingering performance focus spell. Using the spell to maintain the ruse long enough to Earn Income from your art is also quite difficult; because it requires careful timing and repeated deceit, it can�t be assumed to automatically work on an Earn Income check." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0ab67bca-21e9-46bd-9d95-64858a744ed6"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("c6ccf3b3-c0fc-4f14-bce2-cf3e2cea8c62"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("530b3163-bd4c-43cf-8521-46e59b5dcc62"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 122
            };
        }
    }
}
