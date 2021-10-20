using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class PowerfulFist : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Powerful Fist", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You know how to wield your fists as deadly weapons. The damage die for your fist increases to 1d6 instead of 1d4. Most people take a –2 circumstance penalty when making a lethal attack with nonlethal unarmed attacks, because they find it hard to use their fists with deadly force. You don't take this penalty when making a lethal attack with your fist or any other unarmed attacks." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new ModifyWeaponCategoryDamageDieEffect
            {
                Id = Guid.Parse(""),
                Modifier = 1,
                ModifierType = ModifierType.Add,
                WeaponCategoryId = WeaponCategories.Instances.Unarmed.ID
            };

            yield return new DisableLethalUnarmedAttackPenaltyEffect
            {
                Id = Guid.Parse("")
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
