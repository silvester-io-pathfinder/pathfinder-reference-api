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
    public class BasicRedMantisMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("a2f417a5-e648-4e48-8469-bc720bcec829");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Red Mantis Magic",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9a082a26-0045-440a-bdaa-b9b5657dad72"), Type = TextBlockType.Text, Text = $"You have learned limited divine magic from your Red Mantis training. You gain the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity. You're a prepared spellcaster, able to prepare two cantrips and one 1st-level spell each day. You prepare these spells from a Red Mantis assassin spellbook, similar to a wizard's, containing three cantrips and two 1st-level spells. All the spells in your Red Mantis assassin spellbook, from this and later feats, must be either {ToMarkdownLink<Models.Entities.Trait>("transmutation", Traits.Instances.Transmutation.ID)} or {ToMarkdownLink<Models.Entities.Trait>("illusion", Traits.Instances.Illusion.ID)} spells from the arcane spell list or a spell from the following list: {ToMarkdownLink<Models.Entities.Spell>("clairaudience", Spells.Instances.Clairaudience.ID)}, {ToMarkdownLink<Models.Entities.Spell>("clairvoyance", Spells.Instances.Clairvoyance.ID)}, {ToMarkdownLink<Models.Entities.Spell>("darkness", Spells.Instances.Darkness.ID)}, {ToMarkdownLink<Models.Entities.Spell>("dimension door", Spells.Instances.DimensionDoor.ID)}, {ToMarkdownLink<Models.Entities.Spell>("modify memory", Spells.Instances.ModifyMemory.ID)}, {ToMarkdownLink<Models.Entities.Spell>("obscuring mist", Spells.Instances.ObscuringMist.ID)}, {ToMarkdownLink<Models.Entities.Spell>("paralyze", Spells.Instances.Paralyze.ID)}, {ToMarkdownLink<Models.Entities.Spell>("see invisibility", Spells.Instances.SeeInvisibility.ID)}, {ToMarkdownLink<Models.Entities.Spell>("true strike", Spells.Instances.TrueStrike.ID)}. Regardless of their usual magical tradition, your Red Mantis assassin spells are divine spells, as are any Red Mantis focus spells you gain." };
            yield return new TextBlock { Id = Guid.Parse("6ab9ae12-1f20-47f0-a732-c0d7bae3af96"), Type = TextBlockType.Text, Text = $"You can prepare two cantrips and one 1st-level spell each day from those found in your Red Mantis assassin spellbook. You're trained in spell attack rolls and spell DCs for casting divine spells. Your key spellcasting ability for these spells is Charisma." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5f616caa-b4ca-4172-8270-0c7a3847f4e8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            builder.HaveSpecificFeat(Guid.Parse("034d879f-1940-472c-b61d-a6f3c01021d4"), Feats.Instances.RedMantisAssassinDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef1aa79d-5554-4920-a0ae-767159ea0011"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
