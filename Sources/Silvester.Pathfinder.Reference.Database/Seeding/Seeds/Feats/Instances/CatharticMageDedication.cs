using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatharticMageDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("66f6e1e3-8b81-49f7-9968-b13a7891c1bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cathartic Mage Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the cathartic mage archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ab858d4-6746-4c20-b343-c912ac4465bb"), Type = TextBlockType.Text, Text = "You’ve learned to harness a particular emotion and mix it into your magic. Choose an emotion from the Emotional States section to be your catharsis emotion." };
            yield return new TextBlock { Id = Guid.Parse("a52ca433-5545-4112-8988-7a8837e997ba"), Type = TextBlockType.Text, Text = "If you don’t already cast spells from spell slots, you learn to cast spontaneous spells and gain the (action: Cast a Spell) activity. You gain a spell repertoire with one cantrip of your choice, from a spell list of your choice. You choose this cantrip from the common spells on your chosen spell list or from other spells to which you have access on that list. You’re trained in spell attack rolls and spell DCs for that tradition. Your key spellcasting ability for these spells is Charisma." };
            yield return new TextBlock { Id = Guid.Parse("56802ccd-4368-490f-9bd4-199827d3994b"), Type = TextBlockType.Text, Text = "If you can already cast spells from spell slots, you learn one additional cantrip from your spellcasting tradition. If you’re a prepared caster, you can prepare this spell in addition to your usual cantrips per day; if you’re a spontaneous caster, you add this cantrip to your spell repertoire." };
            yield return new TextBlock { Id = Guid.Parse("36aa5930-1416-4726-ab4e-3324e7567fae"), Type = TextBlockType.Text, Text = "You gain the (feat: Catharsis) reaction and the (feat: Settle Emotions) activity" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("340a834a-f369-4fb1-97fa-ef967b5877c8"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("9aa6ddab-cc3f-49b5-a680-0d567f03ff6e"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
                or.Manual(Guid.Parse("24dc28bc-3463-4883-9123-705af714c92f"), "Ability to cast spells from spell slots.");
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecab7598-068c-4ac7-980f-16b071a26bf4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
