using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells
{
    public abstract class AbstractSpellTemplate
    {
        public void Seed(SpellSeeder seeder)
        {
            Spell spell = GetSpell();
            spell.MagicSchoolId = seeder.FilterSchools(MagicSchool)[0].Id;
            spell.ActionTypeId= seeder.FilterActionTypes(ActionType)[0].Id;
            spell.SpellTypeId = seeder.FilterSpellTypes(SpellType)[0].Id;

            if(string.IsNullOrEmpty(SavingThrowStat) == false)
            {
                spell.SavingThrowStatId = seeder.FilterSavingThrowStats(SavingThrowStat)[0].Id;
            }

            RollableEffect? effect = GetRollableEffect();
            if(effect != null)
            {
                seeder.Builder.AddData(effect); 
                spell.RollableEffectId = effect.Id;
            }
            
            foreach (SpellDetailBlock detailBlock in GetSpellDetailBlocks())
            {
                detailBlock.SpellId = spell.Id;
                seeder.Builder.AddData(detailBlock);
            }

            foreach (MagicTradition tradition in seeder.FilterTraditions(GetMagicTraditions().ToArray()))
            {
                seeder.Builder.HasJoinData((spell, tradition));
            }
            
            foreach (SpellComponent component in seeder.FilterSpellComponents(GetSpellComponents().ToArray()))
            {
                seeder.Builder.HasJoinData((spell, component));
            }

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((spell, trait));
            }

            foreach (SpellHeightening heightening in GetHeightenings())
            {
                foreach(SpellHeighteningDetailBlock detail in heightening.Details)
                {
                    detail.SpellHeighteningId = heightening.Id;
                    seeder.Builder.AddData(detail);
                }
                heightening.Details.Clear();

                heightening.SpellId = spell.Id;
                seeder.Builder.AddData(heightening);
            }

            foreach (SpellTrigger trigger in GetTriggers())
            {
                seeder.Builder.AddData(trigger);
                trigger.SpellId = spell.Id;
            }

            foreach (SpellRequirement requirement in GetRequirements())
            {
                seeder.Builder.AddData(requirement);
                requirement.SpellId = spell.Id;
            }

            seeder.Builder.AddData(spell);
        }

        public abstract Spell GetSpell();
        public abstract IEnumerable<string> GetSpellComponents();
        public abstract IEnumerable<string> GetTraits();
        public abstract IEnumerable<string> GetMagicTraditions();
        public abstract string SpellType { get; }
        public abstract string ActionType { get; }
        public abstract string MagicSchool { get; }

        public virtual string SavingThrowStat => "";

        public virtual RollableEffect? GetRollableEffect()
        {
            //Override in concrete subclass to add a rollable effect.
            return null;
        }

        public virtual IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            //Override in concrete subclass to add spell detail blocks for when a single description is not sufficient..
            yield break;
        }

        public virtual IEnumerable<SpellHeightening> GetHeightenings()
        {
            //Override in concrete subclass to add heightened spell effects.
            yield break;
        }

        public virtual IEnumerable<SpellTrigger> GetTriggers()
        {
            //Override in concrete subclass to add trigger conditions.
            yield break;
        }

        public virtual IEnumerable<SpellRequirement> GetRequirements()
        {
            //Override in concrete subclass to add requirement prerequisites.
            yield break;
        }
    }
}
