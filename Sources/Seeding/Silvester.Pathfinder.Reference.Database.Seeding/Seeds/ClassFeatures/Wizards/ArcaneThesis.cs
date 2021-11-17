using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class ArcaneThesis : Template
    {
        public static readonly Guid ID = Guid.Parse("6666cdee-08ff-4ecc-bdd5-104156b456e4");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Arcane Thesis", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d1e99eb1-d1e5-43fe-b6f8-9f3d22354ea8"), Type = TextBlockType.Text, Text = "During your studies to become a full-fledged wizard, you produced a thesis of unique magical research on one of a variety of topics. You gain a special benefit depending on the topic of your thesis research. The arcane thesis topics presented in this book are below; your specific thesis probably has a much longer and more technical title like 'On the Methods of Spell Interpolation and the Genesis of a New Understanding of the Building Blocks of Magic.'" };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyArcaneThesis(Guid.Parse("b68e42e5-3732-48c0-a777-97b480107c4c"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29501f70-a58d-4231-8f49-b47a1a4331c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 205
            };
        }
    }
}
