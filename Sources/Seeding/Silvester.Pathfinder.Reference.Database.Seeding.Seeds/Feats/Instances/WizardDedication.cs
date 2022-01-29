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
    public class WizardDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("8a1a38a1-24a7-40d1-9b34-e9470c20c784");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wizard Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the wizard archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddf15d70-c540-426c-bc80-cf3bb891d1ac"), Type = TextBlockType.Text, Text = $"You cast spells like a wizard, gaining a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)} with four common arcane cantrips of your choice. You gain the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity. You can prepare two cantrips each day from your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)}. You're trained in arcane spell attack rolls and spell DCs. Your key spellcasting ability for wizard archetype spells is Intelligence, and they are arcane wizard spells. You become trained in Arcana; if you were already trained in Arcana, you instead become trained in a skill of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("a823e1f7-80c2-496c-9478-a345e1c22f2e"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("8a5bd3d1-5118-4965-805c-0f2a19d750f7"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("40aff6e1-afc2-4d92-8a5e-524514e03213"), Traits.Instances.Dedication.ID);
            builder.Add(Guid.Parse("fd29582c-de8b-4cac-b669-6bd958e278c2"), Traits.Instances.Multiclass.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28ed80bf-dc7d-4c45-91a5-dc894b93c46d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
