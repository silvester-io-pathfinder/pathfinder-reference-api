using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MastersCounterspell : Template
    {
        public static readonly Guid ID = Guid.Parse("92873f56-fa1a-4064-93d8-1316000e0953");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master's Counterspell",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature Casts a Spell that you have prepared or is in your repertoire, and that spell was cast or created with a tradition of magic in which you have master proficiency in spell attack rolls and spell DCs.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3091dfc-d58f-41dd-8e10-08424ed95aae"), Type = TextBlockType.Text, Text = "When a foe (activity: Casts a Spell | Cast a Spell) and you can see its manifestations, you can use your magic to disrupt it. If you&#39;re a prepared caster, you can expend a prepared spell to counter the triggering creature&#39;s casting of a spell. If you&#39;re a spontaneous caster, you can expend a spell slot. The level of the prepared spell or spell slot must be at least as high as the triggering spell&#39;s level. You lose your prepared spell or spell slot as if you had (activity: Cast the Spell | Cast a Spell). You then attempt to counteract the triggering spell, and you take a -2 penalty to your counteract check; for prepared casters, the GM might waive the penalty if the spell you&#39;re expending to counterspell is especially appropriate – such as countering with the same spell, or using a (spell: cone of cold) to counteract a (spell: fireball)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3a4df9cd-0403-44b7-8474-17fc1f0bd184"), Feats.Instances.SpellmasterDedication.ID);
            builder.HaveSpecificSpellAttackProficiency(Guid.Parse("166a74a9-35a9-42c7-91c2-e9cfedefb140"), Proficiencies.Instances.Master.ID);
            builder.HaveSpecificSpellDcProficiency(Guid.Parse("8be72e9f-4624-4c0f-a548-53e1fe1b5264"), Proficiencies.Instances.Master.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("435ef1a2-91d5-462d-a3bb-775417372fe6"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
