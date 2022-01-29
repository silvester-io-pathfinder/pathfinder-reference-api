using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagusDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("65d1c7dd-2540-4866-9c9b-d4e5c420470a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magus Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the magus archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("329f34e2-1d96-4d33-a043-fe039a5e2f37"), Type = TextBlockType.Text, Text = $"You cast spells like a magus, gaining a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)} with four common arcane cantrips of your choice. You gain the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity. You can prepare two cantrips each day from your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)}. Each time you gain a spell slot of a new level from the magus archetype, add a spell of that level or lower to your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)}. You're trained in arcane spell attack rolls and spell DCs. Your key spellcasting ability for magus archetype spells is Intelligence, and they are arcane magus spells. You become trained in Arcana; if you were already trained in Arcana, you instead become trained in a skill of your choice. You become trained in simple weapons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("5b4e9408-a8ca-4e9e-9b86-a130c3080db7"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("3d3c0ae9-70ae-4439-92f5-565994b16171"), requiredStatValue: 14, Stats.Instances.Strength.ID);
                or.HaveSpecificStat(Guid.Parse("333b4a3a-deab-4da7-827b-f587da4d4440"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
            });
            builder.HaveSpecificStat(Guid.Parse("38260c46-b737-4829-bf4c-521448a6f3c1"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Multiclass.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92760fcf-2f8c-4cf0-8d41-637975a74993"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
