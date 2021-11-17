using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatharticMageDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("8a7db862-16ae-4935-91b1-b786689e3229");

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
            yield return new TextBlock { Id = Guid.Parse("8f216aa4-dc45-4b97-9a72-a990677b4836"), Type = TextBlockType.Text, Text = "You’ve learned to harness a particular emotion and mix it into your magic. Choose an emotion from the Emotional States section to be your catharsis emotion." };
            yield return new TextBlock { Id = Guid.Parse("4e300d62-2f0d-4fdc-95d9-d3aa72923542"), Type = TextBlockType.Text, Text = "If you don’t already cast spells from spell slots, you learn to cast spontaneous spells and gain the (action: Cast a Spell) activity. You gain a spell repertoire with one cantrip of your choice, from a spell list of your choice. You choose this cantrip from the common spells on your chosen spell list or from other spells to which you have access on that list. You’re trained in spell attack rolls and spell DCs for that tradition. Your key spellcasting ability for these spells is Charisma." };
            yield return new TextBlock { Id = Guid.Parse("0c2b263e-1bd9-49cb-b096-ec4a9627fd42"), Type = TextBlockType.Text, Text = "If you can already cast spells from spell slots, you learn one additional cantrip from your spellcasting tradition. If you’re a prepared caster, you can prepare this spell in addition to your usual cantrips per day; if you’re a spontaneous caster, you add this cantrip to your spell repertoire." };
            yield return new TextBlock { Id = Guid.Parse("9c2af386-acd9-4ef8-bd61-7028b0a87028"), Type = TextBlockType.Text, Text = "You gain the (feat: Catharsis) reaction and the (feat: Settle Emotions) activity" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("e71373f1-f983-4387-bed9-2e63f36e31b1"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("9c32d5d7-e7ac-4520-bf3d-6dcf92f905e8"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
                or.Manual(Guid.Parse("450d857f-f24e-4da0-a80d-1f2adc360b63"), "Ability to cast spells from spell slots.");
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
                Id = Guid.Parse("0d263a36-ba97-4465-90f9-df22184d4daf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
