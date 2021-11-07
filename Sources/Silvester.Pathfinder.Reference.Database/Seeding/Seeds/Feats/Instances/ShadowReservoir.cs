using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowReservoir : Template
    {
        public static readonly Guid ID = Guid.Parse("649a1ebe-7137-49f0-9389-305906ada88d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Reservoir",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e4a18ad-055b-483a-95e4-4964a417b92b"), Type = TextBlockType.Text, Text = "Your own shadow speaks to you, providing knowledge of spells and a reservoir of magical power. Your shadow reservoir contains a single spell of each spell level at least 2 levels lower than the highest-level spell you can cast from your spell slots. This spell must come from your spell list, you must have access to it, and it must require a spell attack roll or a saving throw. These spells don’t need to be prepared and aren’t in your repertoire." };
            yield return new TextBlock { Id = Guid.Parse("9c0af797-c46d-4b2f-af0f-ab4fc34316c8"), Type = TextBlockType.Text, Text = "Regardless of the way in which you cast spells, you can spontaneously cast a spell from your shadow reservoir by using one of your spell slots of the same level. If you’re a prepared spellcaster, you lose the spell you prepared in that slot." };
            yield return new TextBlock { Id = Guid.Parse("a6fece88-41e8-4098-9c07-54e62625dcde"), Type = TextBlockType.Text, Text = "Spells cast from your shadow reservoir gain the (trait: shadow) trait, and affected creatures might be able to disbelieve them. If the spell requires an attack roll, use the higher of the target’s AC or their Will DC. If the spell requires a saving throw, the target uses their Will saving throw or the spell’s normal saving throw, whichever is higher. Each time a creature fails its saving throw against a spell cast from your reservoir, you gain a small tattoo inked on your flesh out of pure shadowstuff." };
            yield return new TextBlock { Id = Guid.Parse("b9b1d449-fee5-4420-843a-489273acb6bd"), Type = TextBlockType.Text, Text = "If you have more than one source of spells you can cast with spell slots, such as if you’re a spellcaster with a multiclass archetype, choose one source of spells for your shadow reservoir." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("5b118537-b508-40d8-8dee-bd91ce90f6b2"), "Ability to cast spells from spell slots.");
            builder.HaveSpecificFeat(Guid.Parse("ffebf558-22f9-4795-bdf5-36d2257a8137"), Feats.Instances.ShadowcasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9144bd97-6bea-400b-b98a-7b171edba152"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
