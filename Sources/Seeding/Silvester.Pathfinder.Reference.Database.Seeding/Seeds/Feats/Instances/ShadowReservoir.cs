using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowReservoir : Template
    {
        public static readonly Guid ID = Guid.Parse("be467417-841b-44d9-98c3-11c417a25449");

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
            yield return new TextBlock { Id = Guid.Parse("947a81fa-78a6-43f1-b750-5b6c3a76d01c"), Type = TextBlockType.Text, Text = "Your own shadow speaks to you, providing knowledge of spells and a reservoir of magical power. Your shadow reservoir contains a single spell of each spell level at least 2 levels lower than the highest-level spell you can cast from your spell slots. This spell must come from your spell list, you must have access to it, and it must require a spell attack roll or a saving throw. These spells don't need to be prepared and aren't in your repertoire." };
            yield return new TextBlock { Id = Guid.Parse("0e80c9c3-c129-4331-bd9d-de6e0c188dd2"), Type = TextBlockType.Text, Text = "Regardless of the way in which you cast spells, you can spontaneously cast a spell from your shadow reservoir by using one of your spell slots of the same level. If you're a prepared spellcaster, you lose the spell you prepared in that slot." };
            yield return new TextBlock { Id = Guid.Parse("29a6f891-db2a-4731-b817-3bd300f9e598"), Type = TextBlockType.Text, Text = "Spells cast from your shadow reservoir gain the (trait: shadow) trait, and affected creatures might be able to disbelieve them. If the spell requires an attack roll, use the higher of the target's AC or their Will DC. If the spell requires a saving throw, the target uses their Will saving throw or the spell's normal saving throw, whichever is higher. Each time a creature fails its saving throw against a spell cast from your reservoir, you gain a small tattoo inked on your flesh out of pure shadowstuff." };
            yield return new TextBlock { Id = Guid.Parse("bb44ad2b-28aa-4600-8ab7-5f0b489c1591"), Type = TextBlockType.Text, Text = "If you have more than one source of spells you can cast with spell slots, such as if you're a spellcaster with a multiclass archetype, choose one source of spells for your shadow reservoir." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("747e4a97-8692-49f4-94ed-b5c6e0464500"), "Ability to cast spells from spell slots.");
            builder.HaveSpecificFeat(Guid.Parse("5e35c1a4-44ad-463b-a2fc-761b6eb7d5e2"), Feats.Instances.ShadowcasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5af4d133-8075-4703-93cf-9ddfda83f513"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
