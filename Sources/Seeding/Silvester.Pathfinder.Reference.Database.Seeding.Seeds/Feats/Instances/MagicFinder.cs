using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicFinder : Template
    {
        public static readonly Guid ID = Guid.Parse("8f59a6a5-cda2-4367-9621-85f60f8c023e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Finder",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41a8de37-8114-45f8-a236-8226ec9a4364"), Type = TextBlockType.Text, Text = $"You've learned a few tricks to ensure you find every last magic item and interesting magical effect during your missions. You can cast {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)} and {ToMarkdownLink<Models.Entities.Spell>("read aura", Spells.Instances.ReadAura.ID)} as innate spells at will. You can also cast {ToMarkdownLink<Models.Entities.Spell>("locate", Spells.Instances.Locate.ID)} as an innate spell once per day, but only to locate magic items, not specific mundane objects or types of objects. If you could already cast spells, these spells are of the same tradition. Otherwise, they're arcane spells, you use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for arcane spells." };
            yield return new TextBlock { Id = Guid.Parse("252108ec-23d5-4459-b00c-fdd2b91c2219"), Type = TextBlockType.Text, Text = $"When you cast {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)} or {ToMarkdownLink<Models.Entities.Spell>("read aura", Spells.Instances.ReadAura.ID)} from this feat on an item or creature under the effect of a {ToMarkdownLink<Models.Entities.Spell>("magic aura", Spells.Instances.MagicAura.ID)} spell or interact with an item under the effect of an {ToMarkdownLink<Models.Entities.Spell>("item facade", Spells.Instances.ItemFacade.ID)} spell, you gain a +2 circumstance bonus on your check to disbelieve the illusion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("46dfed07-dcc9-4d54-ab07-1e5e15306996"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa82beb0-75d6-4374-b784-e41b07005c4b"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
