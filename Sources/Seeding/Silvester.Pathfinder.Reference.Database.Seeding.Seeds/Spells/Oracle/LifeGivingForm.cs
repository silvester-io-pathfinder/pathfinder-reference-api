using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LifeGivingForm : Template
    {
        public static readonly Guid ID = Guid.Parse("f8888403-d4a1-4ac5-8946-deaad02e66e5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Life-Giving Form",
                Level = 6,
                IsDismissable = true,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52689e64-c838-4577-9dd6-0935fec93ca4"), Type = TextBlockType.Text, Text = "You transcend your physical form, becoming a beacon of healing energy. Your body exudes bright light like a torch. You gain resistance 5 to precision damage and weakness 5 to negative damage, and your unarmed Strikes deal an extra 1d4 positive damage." };
            yield return new TextBlock { Id = Guid.Parse("bbae0a4a-00a9-4aba-b0b5-7c047065aa61"), Type = TextBlockType.Text, Text = "You can touch a living creature with an Interact action to restore 6d8 Hit Points to it, and when a creature touches you with an Interact action you can allow it to gain the same healing; either way, the creature becomes temporarily immune to life-giving form's healing for 1 minute. This is a positive healing effect. You can't heal yourself with life-giving form. A creature harmed by positive damage (such as an undead) that touches you or damages you with an unarmed attack or non-reach melee weapon instead takes 3d4 positive damage, and it doesn't become temporarily immune." };
            yield return new TextBlock { Id = Guid.Parse("d1e21fdd-c1b5-4b2e-962b-30900d47e734"), Type = TextBlockType.Text, Text = "You can Dismiss this spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a6ece753-431b-4179-b945-8b9192109a6e"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3ee8c02b-1151-4c4f-8bc3-8d0091cd02f0"), Type = TextBlockType.Text, Text = "Increase the Hit Points restored with an Interact action by 1d8, the positive damage by 1, and the resistance and weakness by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ef89fca1-3a30-4852-b801-b8b6c47b1feb"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5f705f2b-b4c3-467a-aaeb-0e0a1aa58068"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("450a5cdb-dcbe-4c1e-92ef-5af72d564460"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("426f3402-4c10-424a-9ceb-60cc42cbad8b"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("df28988e-627d-489a-a08e-6c9e3640425a"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("9eae1930-0044-484d-bd4f-923d57f95509"), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse("9b06df92-8ef0-4999-9a46-ec16ddb51e4e"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd41031e-4a80-41ad-a99c-4d0848105b97"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 232
            };
        }
    }
}
