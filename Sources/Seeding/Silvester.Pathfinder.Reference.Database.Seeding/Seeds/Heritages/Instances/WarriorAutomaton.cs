using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class WarriorAutomaton : Template
    {
        public static readonly Guid ID = Guid.Parse("88292a4e-7f00-46e6-afdd-5c2ed5bebb43");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Warrior Automaton"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("af4ea14a-3f9f-4d88-a922-eeca6e825856"), Type = TextBlockType.Text, Text = "Sporting a bulkier, powerful design, your body has been designed for combat. You have a bulky, humanoid shape. The damage die for your fist increases to 1d6 instead of 1d4. You don't take a penalty when making a lethal attack with your fist or any other unarmed attack." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifySpecificWeaponCategoryDamageDieSize(Guid.Parse("fbc97c5b-bb93-41d4-b390-7e342e2752cb"), WeaponCategories.Instances.Unarmed.ID, ModifierType.Add, modifier: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d859b231-d584-4607-b331-30758bed56db"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 36
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Automaton.ID;
        }
    }
}
