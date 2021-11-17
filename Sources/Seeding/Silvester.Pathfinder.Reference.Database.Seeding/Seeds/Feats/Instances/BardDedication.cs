using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BardDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("23c6ab40-8ca9-4bb3-9b6b-cbe04349c439");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bard Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the bard archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a3e2bc0-9d50-42d7-9df6-0397aabc336b"), Type = TextBlockType.Text, Text = "You cast spells like a bard and gain the (activity: Cast a Spell) activity. You gain a spell repertoire with two common cantrips from the occult spell list, or any other cantrips you learn or discover. You’re trained in spell attack rolls and spell DCs for occult spells. Your key spellcasting ability for bard archetype spells is Charisma, and they are occult bard spells. You become trained in Occultism and Performance; for each of these skills in which you were already trained, you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("4ab38a12-1a81-4e24-9c65-82fad9420ff2"), Type = TextBlockType.Text, Text = "Choose a muse as you would if you were a bard. You have that muse for all purposes, allowing you to take that muse’s feats, but you don’t gain any of the other abilities it grants." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("0a6327d8-9136-451c-add8-ba596c49f541"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ade97acb-3d97-4cd3-b36d-46fb8fde7a95"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
